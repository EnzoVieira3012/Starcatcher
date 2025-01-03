using Starcatcher.Api.Domain.Repositories;
using Starcatcher.Infrastructure.Data;
using Starcatcher.Api.Common.Exceptions;
using Starcatcher.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Starcatcher.Api.Infrastructure.Repositories
{
    public class UserRepository(DatabaseContext context) : IUserRepository
    {
        private readonly DatabaseContext _context = context;

        public IEnumerable<User> GetUsers()
        {
            return _context.Users.Include(u => u.Wallet).Include(u => u.Quotas);
        }

        public User GetUserById(int id)
        {
            return _context.Users.Include(u => u.Wallet).Include(u => u.Quotas).FirstOrDefault(u => u.UserId == id)
                ?? throw new UserNotFoundException();
        }

        public User Add(User user)
        {
            _context.Users.Add(user);
            _context.Wallets.Add(new Wallet
            {
                User = user,
                UserId = user.UserId,
                Balance = 0,
                CreatedAt = DateTime.Now
            });

            _context.SaveChanges();
            return user;
        }

        public User Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return user;
        }

        public void Delete(User user, Wallet wallet)

        {
            _context.Users.Update(user);
            _context.Wallets.Update(wallet);
            _context.SaveChanges();
        }

        public User? GetUserByEmail(string email)
        {
            return _context.Users.Include(u => u.Wallet).FirstOrDefault(u => u.Email == email);
        }
    }
}