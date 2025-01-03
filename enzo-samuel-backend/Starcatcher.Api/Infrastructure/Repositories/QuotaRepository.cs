using Starcatcher.Api.Domain.Repositories;
using Starcatcher.Infrastructure.Data;
using Starcatcher.Api.Common.Exceptions;
using Starcatcher.Api.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Starcatcher.Api.Infrastructure.Repositories
{
    public class QuotaRepository : IQuotaRepository
    {
        private readonly DatabaseContext _context;

        public QuotaRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Quota> GetAllQuotas()
        {
            return _context.Quotas;
        }

        public IEnumerable<Quota> GetQuotasByConsortiumId(int consortiumId)
        {
            return _context.Quotas.Where(q => q.ConsortiumId == consortiumId);
        }

        public Quota? GetQuotaById(int id)
        {
            return _context.Quotas.FirstOrDefault(q => q.QuotaId == id) ?? throw new QuotaNotFoundException();
        }

        public IEnumerable<Quota> GetQuotasByUserId(int userId)
        {
            return _context.Quotas.Where(q => q.UserId == userId).ToList();
        }

        public Quota CreateQuota(Quota quota)
        {
            var newQuota = _context.Quotas.Add(quota);
            _context.SaveChanges();
            return newQuota.Entity;
        }

        public Quota UpdateQuota(Quota quota)
        {
            _context.Quotas.Update(quota);
            _context.SaveChanges();
            return quota;
        }

        public void DeleteQuota(Quota quota)
        {
            _context.Quotas.Update(quota);
            _context.SaveChanges();
        }

        public Quota? GetQuotaByNumber(string quotaNumber)
        {
            return _context.Quotas.FirstOrDefault(q => q.QuotaNumber == quotaNumber);
        }

        public Quota BuyQuota(Quota quota, User user, Wallet wallet)
        {
            _context.Wallets.Update(wallet);
            _context.Quotas.Update(quota);
            _context.Users.Update(user);
            _context.SaveChanges();
            return quota;
        }
    }
}