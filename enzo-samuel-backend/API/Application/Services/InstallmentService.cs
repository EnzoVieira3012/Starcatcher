using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Domain.Interfaces;
using API.Application.DTOs;
using API.Domain.Entities;

namespace API.Application.Services
{
    public class InstallmentService : IInstallmentService
    {
        private readonly IInstallmentRepository _installmentRepository;
        private readonly IQuotaService _quotaService;

        public InstallmentService(IInstallmentRepository installmentRepository, IQuotaService quotaService)
        {
            _installmentRepository = installmentRepository;
            _quotaService = quotaService;
        }

        public async Task<IEnumerable<InstallmentDto>> GetInstallmentsByQuotaIdAsync(int quotaId)
        {
            var installments = await _installmentRepository.GetByQuotaIdAsync(quotaId);
            return installments.Select(i => new InstallmentDto
            {
                Id = i.Id,
                Value = i.Value,
                Status = i.Status.ToString()
            });
        }

        public async Task MarkInstallmentAsPaidAsync(int installmentId)
        {
            var installment = await _installmentRepository.GetByIdAsync(installmentId);
            if (installment != null && installment.Status == InstallmentStatus.Pendente)
            {
                installment.Status = InstallmentStatus.Pago;
                await _installmentRepository.UpdateAsync(installment);
                await _quotaService.CheckAndUpdateQuotaStatusIfPaid(installment.QuotaId);
            }
            else
            {
                throw new KeyNotFoundException("Installment not found or already paid.");
            }
        }
    }
}