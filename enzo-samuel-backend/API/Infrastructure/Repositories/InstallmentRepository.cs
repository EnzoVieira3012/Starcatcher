using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data;

namespace API.Infrastructure.Repositories
{
    public class InstallmentRepository : IInstallmentRepository
    {
        private readonly ApplicationDbContext _context;

        public InstallmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Installment installment)
        {
            await _context.Installments.AddAsync(installment);
            await _context.SaveChangesAsync();
        }

        public async Task<Installment?> GetByIdAsync(int installmentId)
        {
            return await _context.Installments.FindAsync(installmentId);
        }

        public async Task UpdateAsync(Installment installment)
        {
            _context.Installments.Update(installment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int installmentId)
        {
            var installment = await GetByIdAsync(installmentId);
            if (installment != null)
            {
                _context.Installments.Remove(installment);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Installment>> GetByQuotaIdAsync(int quotaId)
        {
            return await _context.Installments
                .Where(i => i.QuotaId == quotaId)
                .ToListAsync();
        }
    }
}