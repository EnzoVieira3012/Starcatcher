using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Application.DTOs;
using API.Domain.Entities;
using API.Domain.Interfaces;

namespace API.Application.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task CreateClientAsync(CreateClientDto clientDto, Guid userId)
        {
            var client = new Client
            {
                Name = clientDto.Name,
                Email = clientDto.Email,
                Phone = clientDto.Phone,
                UserId = userId
            };

            await _clientRepository.AddAsync(client);
        }

        public async Task<IEnumerable<ClientDto>> GetClientsByUserIdAsync(Guid userId)
        {
            var clients = await _clientRepository.GetClientsByUserIdAsync(userId);
            return clients.Select(c => new ClientDto
            {
                Id = c.Id,
                Name = c.Name,
                Email = c.Email,
                Phone = c.Phone
            });
        }

        public async Task UpdateClientAsync(int clientId, UpdateClientDto clientDto)
        {
            var client = await _clientRepository.GetByIdAsync(clientId);
            if (client == null)
            {
                throw new KeyNotFoundException("Client not found.");
            }

            if (clientDto.Name != null)
            {
                client.Name = clientDto.Name;
            }

            if (clientDto.Email != null)
            {
                client.Email = clientDto.Email;
            }

            if (clientDto.Phone != null)
            {
                client.Phone = clientDto.Phone;
            }

            await _clientRepository.UpdateAsync(client);
        }

        public async Task DeleteClientAsync(int clientId)
        {
            await _clientRepository.DeleteAsync(clientId);
        }
    }
}