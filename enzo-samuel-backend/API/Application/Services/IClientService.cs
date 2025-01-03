using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Application.DTOs;

namespace API.Application.Services
{
    public interface IClientService
    {
        Task CreateClientAsync(CreateClientDto clientDto, Guid userId);
        Task<IEnumerable<ClientDto>> GetClientsByUserIdAsync(Guid userId);
        Task UpdateClientAsync(int clientId, UpdateClientDto clientDto);
        Task DeleteClientAsync(int clientId);
    }
}