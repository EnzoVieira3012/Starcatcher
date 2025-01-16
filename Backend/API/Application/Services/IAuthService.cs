using System;
using System.Threading.Tasks;
using API.Application.DTOs;
using API.Domain.Entities;

namespace API.Application.Services
{
    public interface IAuthService
    {
        Task<string> Register(UserRegistrationDto registrationDto);
        Task<string> Login(UserLoginDto loginDto);
        Task ChangePassword(string email, string newPassword);
        Task UpdateEmail(Guid userId, string newEmail);
        Task UpdateUserName(Guid userId, string newName);
        Task DeleteUser(Guid userId, string password);
        Task<User?> GetUserByIdAsync(Guid userId);
    }
}