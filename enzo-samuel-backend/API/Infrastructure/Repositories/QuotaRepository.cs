using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Infrastructure.Repositories
{
    public class QuotaRepository : IQuotaRepository
    {
        private readonly ApplicationDbContext _context;

        public QuotaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Quota quota)
        {
            await _context.Quotas.AddAsync(quota);
            await _context.SaveChangesAsync();
        }

        public async Task<Quota?> GetByIdAsync(int quotaId)
        {
            return await _context.Quotas.FindAsync(quotaId);
        }

        public async Task UpdateAsync(Quota quota)
        {
            _context.Quotas.Update(quota);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int quotaId)
        {
            var quota = await GetByIdAsync(quotaId);
            if (quota != null)
            {
                _context.Quotas.Remove(quota);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Quota>> GetByConsortiumIdAsync(int consortiumId)
        {
            return await _context.Quotas
                .Where(q => q.ConsortiumId == consortiumId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Quota>> GetLastNQuotasByConsortiumIdAsync(int consortiumId, int n)
        {
            return await _context.Quotas
                .Where(q => q.ConsortiumId == consortiumId)
                .OrderByDescending(q => q.Id)
                .Take(n)
                .ToListAsync();
        }

        public async Task<IEnumerable<Quota>> GetByClientIdAsync(int clientId)
        {
            return await _context.Quotas
                .Where(q => q.ClientId == clientId)
                .ToListAsync();
        }
    }
}