using System.Collections.Generic;
using System.Threading.Tasks;
using API.Application.DTOs;

namespace API.Application.Services
{
    public interface IInstallmentService
    {
        Task<IEnumerable<InstallmentDto>> GetInstallmentsByQuotaIdAsync(int quotaId);
        Task MarkInstallmentAsPaidAsync(int installmentId);
    }
}