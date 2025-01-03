using Starcatcher.Api.Application.DTO;
using Starcatcher.Api.Domain.Repositories;
using Starcatcher.Api.Common.Exceptions;
using Starcatcher.Api.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Starcatcher.Api.Application.Services
{
    public class QuotaService : IQuotaService
    {
        private readonly IQuotaRepository _quotaRepository;
        private readonly IWalletRepository _walletRepository;
        private readonly IConsortiumRepository _consortiumRepository;

        public QuotaService(IQuotaRepository quotaRepository, IWalletRepository walletRepository, IConsortiumRepository consortiumRepository)
        {
            _quotaRepository = quotaRepository;
            _walletRepository = walletRepository;
            _consortiumRepository = consortiumRepository;
        }

        public IEnumerable<QuotaDto> GetAllQuotas()
        {
            return _quotaRepository.GetAllQuotas().Select(QuotaDto.FromEntity).ToList();
        }

        public IEnumerable<QuotaDto> GetByConsortiumId(int consortiumId)
        {
            _consortiumRepository.GetConsortiumById(consortiumId);
            return _quotaRepository.GetQuotasByConsortiumId(consortiumId).Select(QuotaDto.FromEntity).ToList();
        }

        public QuotaDto? GetQuotaById(int id)
        {
            return QuotaDto.FromEntity(_quotaRepository.GetQuotaById(id)!);
        }

        public IEnumerable<QuotaDto> GetQuotasByUserId(int userId)
        {
            var quotas = _quotaRepository.GetQuotasByUserId(userId);
            return quotas.Select(QuotaDto.FromEntity).ToList();
        }

        public QuotaDto CreateQuota(CreationQuotaDto quota)
        {
            Quota? existingQuota = _quotaRepository.GetQuotaByNumber(quota.QuotaNumber);
            if (existingQuota != null) throw new QuotaNumberInUseException();
            Consortium? consortium = _consortiumRepository.GetConsortiumById(quota.ConsortiumId)!;
            if (consortium.ClosedAt != null) throw new ConsortiumIsClosedException();
            return QuotaDto.FromEntity(_quotaRepository.CreateQuota(quota.ToEntity()));
        }

        public QuotaDto UpdateQuota(UpdateQuotaDto quota)
        {
            Quota? existingQuota = _quotaRepository.GetQuotaById(quota.QuotaId)!;
            if (existingQuota.QuotaNumber != quota.QuotaNumber &&
                _quotaRepository.GetQuotaByNumber(quota.QuotaNumber) != null)
                throw new QuotaNumberInUseException();
            Consortium? consortium = _consortiumRepository.GetConsortiumById(quota.ConsortiumId)!;
            if (consortium.ClosedAt != null) throw new ConsortiumIsClosedException();
            existingQuota.QuotaNumber = quota.QuotaNumber;
            existingQuota.Value = quota.Value;
            existingQuota.Status = quota.Status;
            existingQuota.UpdatedAt = DateTime.Now;
            existingQuota.ConsortiumId = quota.ConsortiumId;
            return QuotaDto.FromEntity(_quotaRepository.UpdateQuota(existingQuota));
        }

        public void DeleteQuota(int id)
        {
            Quota? existingQuota = _quotaRepository.GetQuotaById(id)!;
            existingQuota.DeletedAt = DateTime.Now;
            _quotaRepository.DeleteQuota(existingQuota);
        }

        public QuotaDto BuyQuota(int id, User user)
        {
            Quota? existingQuota = _quotaRepository.GetQuotaById(id)!;
            if (existingQuota.Status != 0) throw new UnavailableQuotaException();
            if (user.Wallet == null) throw new WalletNotFoundException();
            Wallet wallet = _walletRepository.GetWalletById(user.Wallet.WalletId)!;
            if (existingQuota.Value > wallet.Balance) throw new InsufficientBalanceException();
            wallet.Balance -= existingQuota.Value;
            existingQuota.Status = (ConsortiumStatus)1;
            existingQuota.UserId = user.UserId;
            existingQuota.UpdatedAt = DateTime.Now;
            return QuotaDto.FromEntity(_quotaRepository.BuyQuota(existingQuota, user, wallet));
        }
    }
}