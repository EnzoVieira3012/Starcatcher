using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Domain.Entities;

namespace API.Domain.Interfaces
{
    public interface IConsortiumRepository
    {
        Task AddAsync(Consortium consortium);
        Task<int> GetNextConsortiumNumber(Guid userId);
        Task<IEnumerable<Consortium>> GetConsortiaByUserIdAsync(Guid userId);
        Task<Consortium?> GetByIdAsync(int consortiumId);
        Task UpdateAsync(Consortium consortium);
        Task DeleteAsync(int consortiumId);
    }
}