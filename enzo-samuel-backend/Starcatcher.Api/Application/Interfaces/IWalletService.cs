using Starcatcher.Api.Application.DTO;

namespace Starcatcher.Api.Application.Services
{
  public interface IWalletService
  {
    IEnumerable<WalletDto> GetWallets();
    WalletDto? GetWalletById(int id);
    WalletDto Credit(CreditBalanceWalletDto creditBalanceWalletDto);
  }
}