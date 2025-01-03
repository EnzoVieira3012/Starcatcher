using Starcatcher.Api.Application.DTO;
using Starcatcher.Api.Common;
using Starcatcher.Api.Common.Exceptions;
using Starcatcher.Api.Domain.Entities;
using Starcatcher.Api.Domain.Repositories;

namespace Starcatcher.Api.Application.Services
{
    public class WalletService : IWalletService
    {
        private readonly IWalletRepository _walletRepository;
        private readonly UserUtils _userUtils;

        public WalletService(IWalletRepository walletRepository, UserUtils userUtils)
        {
            _walletRepository = walletRepository;
            _userUtils = userUtils;
        }

        public WalletDto Credit(CreditBalanceWalletDto creditBalanceWalletDto)
        {
            User authenticatedUser = _userUtils.GetAuthenticatedUser()!;
            if (authenticatedUser.Wallet == null) throw new WalletNotFoundException();
            Wallet? wallet = _walletRepository.GetWalletById(authenticatedUser.Wallet.WalletId);
            if (wallet == null) throw new WalletNotFoundException();
            wallet.Balance += creditBalanceWalletDto.Amount;
            wallet.UpdatedAt = DateTime.Now;
            _walletRepository.Credit(wallet);
            return WalletDto.FromEntity(wallet);
        }

        public WalletDto? GetWalletById(int id)
        {
            Wallet? wallet = _walletRepository.GetWalletById(id);
            if (wallet == null) throw new WalletNotFoundException();
            return WalletDto.FromEntity(wallet);
        }

        public IEnumerable<WalletDto> GetWallets()
        {
            return _walletRepository.GetWallets().Select(WalletDto.FromEntity).ToList();
        }
    }
}