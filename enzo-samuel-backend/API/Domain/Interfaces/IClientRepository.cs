using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Domain.Entities;

namespace API.Domain.Interfaces
{
    public interface IClientRepository
    {
        Task AddAsync(Client client);
        Task<IEnumerable<Client>> GetClientsByUserIdAsync(Guid userId);
        Task<Client?> GetByIdAsync(int clientId);
        Task UpdateAsync(Client client);
        Task DeleteAsync(int clientId);
    }
}