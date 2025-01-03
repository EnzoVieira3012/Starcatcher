using Starcatcher.Api.Domain.Entities;

namespace Starcatcher.Api.Domain.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User? GetUserByEmail(string email);
        User? GetUserById(int id);
        User Add(User user);
        User Update(User user);
        void Delete(User user, Wallet wallet);
    }
}