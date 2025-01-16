using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data;

namespace API.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            if (_context.Users != null)
            {
                return await _context.Users.SingleOrDefaultAsync(u => u.Email == email);
            }

            return null;
        }

        public async Task<User?> GetByIdAsync(Guid userId)
        {
            if (_context.Users != null)
            {
                return await _context.Users.FindAsync(userId);
            }

            return null;
        }

        public async Task AddAsync(User user)
        {
            if (_context.Users != null)
            {
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Users DbSet is not initialized.");
            }
        }

        public async Task UpdateAsync(User user)
        {
            if (_context.Users != null)
            {
                _context.Users.Update(user);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Users DbSet is not initialized.");
            }
        }

        public async Task DeleteAsync(Guid userId)
        {
            if (_context.Users != null)
            {
                var user = await _context.Users.FindAsync(userId);
                if (user != null)
                {
                    _context.Users.Remove(user);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    throw new Exception("User not found.");
                }
            }
            else
            {
                throw new InvalidOperationException("Users DbSet is not initialized.");
            }
        }
    }
}