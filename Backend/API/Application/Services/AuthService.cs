using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using API.Application.DTOs;
using API.Domain.Entities;
using API.Domain.Interfaces;
using BCrypt.Net;

namespace API.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;

        public AuthService(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }

        public async Task<string> Register(UserRegistrationDto registrationDto)
        {
            if (string.IsNullOrEmpty(registrationDto.Email))
            {
                throw new ArgumentException("Email cannot be null or empty.");
            }

            var existingUser = await _userRepository.GetByEmailAsync(registrationDto.Email);
            if (existingUser != null)
            {
                throw new Exception("User already exists.");
            }

            var user = new User
            {
                Name = registrationDto.Name,
                Email = registrationDto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(registrationDto.Password)
            };

            await _userRepository.AddAsync(user);

            return GenerateJwtToken(user);
        }

        public async Task<string> Login(UserLoginDto loginDto)
        {
            if (string.IsNullOrEmpty(loginDto.Email))
            {
                throw new ArgumentException("Email cannot be null or empty.");
            }

            var user = await _userRepository.GetByEmailAsync(loginDto.Email);
            if (user == null || !BCrypt.Net.BCrypt.Verify(loginDto.Password, user.PasswordHash))
            {
                throw new Exception("Invalid credentials.");
            }

            return GenerateJwtToken(user);
        }

        public async Task ChangePassword(string email, string newPassword)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Email cannot be null or empty.");
            }

            var user = await _userRepository.GetByEmailAsync(email);
            if (user == null)
            {
                throw new Exception("User not found.");
            }

            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(newPassword);

            await _userRepository.UpdateAsync(user);
        }

        public async Task UpdateUserName(Guid userId, string newName)
        {
            if (string.IsNullOrEmpty(newName))
            {
                throw new ArgumentException("Name cannot be null or empty.");
            }

            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null)
            {
                throw new Exception("User not found.");
            }

            user.Name = newName;

            await _userRepository.UpdateAsync(user);
        }

        public async Task UpdateEmail(Guid userId, string newEmail)
        {
            if (string.IsNullOrEmpty(newEmail))
            {
                throw new ArgumentException("Email cannot be null or empty.");
            }

            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null)
            {
                throw new Exception("User not found.");
            }

            user.Email = newEmail;

            await _userRepository.UpdateAsync(user);
        }

        public async Task DeleteUser(Guid userId, string password)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null)
            {
                throw new Exception("User not found.");
            }

            if (!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                throw new Exception("Invalid password.");
            }

            await _userRepository.DeleteAsync(userId);
        }

        public async Task<User?> GetUserByIdAsync(Guid userId)
        {
            return await _userRepository.GetByIdAsync(userId);
        }

        private string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = _configuration["Jwt:Key"];
            if (string.IsNullOrEmpty(key))
            {
                throw new InvalidOperationException("JWT Key is not configured.");
            }

            var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key));

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}