using Microsoft.AspNetCore.Identity;
using Starcatcher.Api.Application.DTO;
using Starcatcher.Api.Domain.Repositories;
using Starcatcher.Api.Common.Exceptions;
using Starcatcher.Api.Domain.Entities;
using Starcatcher.Api.Common;

namespace Starcatcher.Api.Application.Services
{
    public class UserService(IUserRepository userRepository, IWalletRepository walletRepository, UserUtils userUtils) : IUserService
    {
        private readonly IUserRepository _userRepository = userRepository;
        private readonly IWalletRepository _walletRepository = walletRepository;
        private readonly TokenGenerator _tokenGenerator = new();
        private readonly PasswordHasher<User> _passwordHasher = new();
        private readonly UserUtils _userUtils = userUtils;

        public IEnumerable<UserDto> GetAllUsers()
        {
            return _userRepository.GetUsers().Select(UserDto.FromEntity).ToList();
        }

        public UserDto CreateUser(CreationUserDto user)
        {
            if (GetUserByEmail(user.Email) != null)
                throw new EmailInUseException();

            User newUser = user.ToEntity();
            newUser.Password = _passwordHasher.HashPassword(newUser, user.Password);

            return UserDto.FromEntity(_userRepository.Add(newUser));
        }

        public UserDto UpdateUser(UpdateUserDto user)
        {
            User authenticatedUser = _userUtils.GetAuthenticatedUser()!;

            if (authenticatedUser.Email != user.Email && GetUserByEmail(user.Email) != null)
                throw new EmailInUseException();

            authenticatedUser.Name = user.Name;
            authenticatedUser.Email = user.Email;
            authenticatedUser.Password = _passwordHasher.HashPassword(authenticatedUser, user.Password);
            authenticatedUser.UpdatedAt = DateTime.Now;

            return UserDto.FromEntity(_userRepository.Update(authenticatedUser));
        }

        public UserDto GetUserById(int id)
        {
            User user = _userRepository.GetUserById(id) ?? throw new UserNotFoundException();
            return UserDto.FromEntity(user);
        }

        public void DeleteUser()
        {
            User authenticatedUser = _userUtils.GetAuthenticatedUser()!;

            if (authenticatedUser.Wallet == null) throw new WalletNotFoundException();

            Wallet? wallet = _walletRepository.GetWalletById(authenticatedUser.Wallet.WalletId)!;

            authenticatedUser.DeletedAt = DateTime.Now;
            wallet.DeletedAt = DateTime.Now;
            wallet.Balance = 0;

            _userRepository.Delete(authenticatedUser, wallet);
        }

        public User? GetUserByEmail(string email)
        {
            return _userRepository.GetUserByEmail(email);
        }

        public LoginDtoResponse Login(LoginDtoRequest loginDto)
        {
            User? existingUser = GetUserByEmail(loginDto.Email) ?? throw new UnauthorizedException();

            var passwordVerificationResult = _passwordHasher.VerifyHashedPassword(existingUser, existingUser.Password, loginDto.Password);
            if (passwordVerificationResult != PasswordVerificationResult.Success) throw new UnauthorizedException();

            
            return new LoginDtoResponse { Token = _tokenGenerator.Generate(existingUser) };

        }

    }
}