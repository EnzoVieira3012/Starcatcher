using System.Collections.Generic;
using System.Threading.Tasks;
using API.Application.DTOs;

namespace API.Application.Services
{
    public interface IQuotaService
    {
        Task LinkQuotaToClientAsync(int quotaId, int clientId);
        Task CheckAndUpdateQuotaStatusIfPaid(int quotaId);
        Task<IEnumerable<QuotaDto>> GetQuotasByClientIdAsync(int clientId);
    }
}