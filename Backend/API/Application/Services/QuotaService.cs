using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Application.DTOs;
using API.Domain.Entities;
using API.Domain.Interfaces;

namespace API.Application.Services
{
    public class QuotaService : IQuotaService
    {
        private readonly IQuotaRepository _quotaRepository;
        private readonly IInstallmentRepository _installmentRepository;
        private readonly IClientRepository _clientRepository;

        public QuotaService(
            IQuotaRepository quotaRepository,
            IInstallmentRepository installmentRepository,
            IClientRepository clientRepository)
        {
            _quotaRepository = quotaRepository;
            _installmentRepository = installmentRepository;
            _clientRepository = clientRepository;
        }

        public async Task LinkQuotaToClientAsync(int quotaId, int clientId)
        {
            var quota = await _quotaRepository.GetByIdAsync(quotaId);
            if (quota == null || quota.Status != QuotaStatus.Disponivel)
            {
                throw new InvalidOperationException("Quota not available.");
            }

            var client = await _clientRepository.GetByIdAsync(clientId);
            if (client == null)
            {
                throw new KeyNotFoundException("Client not found.");
            }

            quota.ClientId = clientId;
            quota.Status = QuotaStatus.Vinculada;

            await _quotaRepository.UpdateAsync(quota);
        }

        public async Task CheckAndUpdateQuotaStatusIfPaid(int quotaId)
        {
            var installments = await _installmentRepository.GetByQuotaIdAsync(quotaId);
            if (installments.All(i => i.Status == InstallmentStatus.Pago))
            {
                var quota = await _quotaRepository.GetByIdAsync(quotaId);
                if (quota != null && quota.Status != QuotaStatus.Inativa)
                {
                    quota.Status = QuotaStatus.Inativa;
                    await _quotaRepository.UpdateAsync(quota);
                }
            }
        }

        public async Task<IEnumerable<QuotaDto>> GetQuotasByClientIdAsync(int clientId)
        {
            var quotas = await _quotaRepository.GetByClientIdAsync(clientId);
            return quotas.Select(q => new QuotaDto
            {
                Id = q.Id,
                ConsortiumId = q.ConsortiumId,
                Status = q.Status.ToString()
            });
        }
    }
}