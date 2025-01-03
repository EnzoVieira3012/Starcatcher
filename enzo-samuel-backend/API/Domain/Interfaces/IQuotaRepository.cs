using System.Collections.Generic;
using System.Threading.Tasks;
using API.Domain.Entities;

namespace API.Domain.Interfaces
{
    public interface IQuotaRepository
    {
        Task AddAsync(Quota quota);
        Task<Quota?> GetByIdAsync(int quotaId);
        Task UpdateAsync(Quota quota);
        Task DeleteAsync(int quotaId);
        Task<IEnumerable<Quota>> GetByConsortiumIdAsync(int consortiumId);
        Task<IEnumerable<Quota>> GetLastNQuotasByConsortiumIdAsync(int consortiumId, int n);
        Task<IEnumerable<Quota>> GetByClientIdAsync(int clientId);
    }
}