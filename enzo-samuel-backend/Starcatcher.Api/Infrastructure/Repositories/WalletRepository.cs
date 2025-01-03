using Starcatcher.Infrastructure.Data;
using Starcatcher.Api.Common.Exceptions;
using Starcatcher.Api.Domain.Repositories;
using Starcatcher.Api.Domain.Entities;


namespace Starcatcher.Api.Infrastructure.Repositories
{
    public class WalletRepository(DatabaseContext context) : IWalletRepository
    {
        private readonly DatabaseContext _context = context;

        public IEnumerable<Wallet> GetWallets()
        {
            return _context.Wallets;
        }

        public Wallet? GetWalletById(int id)
        {
            return _context.Wallets.FirstOrDefault(w => w.WalletId == id) ?? throw new WalletNotFoundException();
        }

        public Wallet Credit(Wallet wallet)
        {
            _context.Wallets.Update(wallet);
            _context.SaveChanges();
            return wallet;
        }
    }
}