using Starcatcher.Api.Domain.Entities;

namespace Starcatcher.Api.Domain.Repositories;
public interface IWalletRepository
{

    IEnumerable<Wallet> GetWallets();
    Wallet? GetWalletById(int id);
    Wallet Credit(Wallet wallet);
    
}