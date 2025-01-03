using System.Collections.Generic;
using System.Threading.Tasks;
using API.Domain.Entities;

namespace API.Domain.Interfaces
{
    public interface IInstallmentRepository
    {
        Task AddAsync(Installment installment);
        Task<Installment?> GetByIdAsync(int installmentId);
        Task UpdateAsync(Installment installment);
        Task DeleteAsync(int installmentId);
        Task<IEnumerable<Installment>> GetByQuotaIdAsync(int quotaId);
    }
}