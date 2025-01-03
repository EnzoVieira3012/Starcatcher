using Starcatcher.Api.Domain.Entities;
using System.Collections.Generic;

namespace Starcatcher.Api.Domain.Repositories
{
    public interface IQuotaRepository
    {
        IEnumerable<Quota> GetAllQuotas();
        IEnumerable<Quota> GetQuotasByConsortiumId(int consortiumId);
        Quota? GetQuotaById(int id);
        Quota CreateQuota(Quota quota);
        Quota UpdateQuota(Quota quota);
        void DeleteQuota(Quota quota);
        Quota? GetQuotaByNumber(string quotaNumber);
        Quota BuyQuota(Quota quota, User user, Wallet wallet);
        IEnumerable<Quota> GetQuotasByUserId(int userId);
    }
}