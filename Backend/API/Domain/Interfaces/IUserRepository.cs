using System;
using System.Threading.Tasks;
using API.Domain.Entities;

namespace API.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByEmailAsync(string email);
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task<User?> GetByIdAsync(Guid userId);
        Task DeleteAsync(Guid userId);
    }
}