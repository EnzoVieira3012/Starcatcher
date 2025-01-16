using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Application.DTOs;

namespace API.Application.Services
{
    public interface IConsortiumService
    {
        Task CreateConsortiumAsync(CreateConsortiumDto consortiumDto, Guid userId);
        Task<IEnumerable<ConsortiumDto>> GetConsortiaByUserIdAsync(Guid userId);
        Task UpdateConsortiumAsync(int consortiumId, UpdateConsortiumDto updateDto);
        Task<bool> IsUserOwnerOfConsortiumAsync(Guid userId, int consortiumId);
        Task DeleteConsortiumAsync(int consortiumId);
        Task<IEnumerable<QuotaDto>> GetQuotasByConsortiumIdAsync(int consortiumId, Guid userId);
    }
}