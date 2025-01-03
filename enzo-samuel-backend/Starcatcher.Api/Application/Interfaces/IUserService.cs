using Starcatcher.Api.Application.DTO;
using Starcatcher.Api.Domain.Entities;

namespace Starcatcher.Api.Application.Services
{
    public interface IUserService
    {
        IEnumerable<UserDto> GetAllUsers();
        UserDto CreateUser(CreationUserDto user);
        UserDto UpdateUser(UpdateUserDto user);
        UserDto GetUserById(int id);
        User? GetUserByEmail(string email);
        void DeleteUser();
        LoginDtoResponse Login(LoginDtoRequest loginDto);
    }
}