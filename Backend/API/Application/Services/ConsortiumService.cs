using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Application.DTOs;
using API.Domain.Interfaces;
using API.Domain.Entities;
using API.Infrastructure.Data;

namespace API.Application.Services
{
    public class ConsortiumService : IConsortiumService
    {
        private readonly IConsortiumRepository _consortiumRepository;
        private readonly IQuotaRepository _quotaRepository;
        private readonly IInstallmentRepository _installmentRepository;
        private readonly ApplicationDbContext _context;

        public ConsortiumService(
            IConsortiumRepository consortiumRepository,
            IQuotaRepository quotaRepository,
            IInstallmentRepository installmentRepository,
            ApplicationDbContext context)
        {
            _consortiumRepository = consortiumRepository;
            _quotaRepository = quotaRepository;
            _installmentRepository = installmentRepository;
            _context = context;
        }

        public async Task CreateConsortiumAsync(CreateConsortiumDto consortiumDto, Guid userId)
        {
            var nextNumber = await _consortiumRepository.GetNextConsortiumNumber(userId);

            if (nextNumber > 999)
            {
                throw new InvalidOperationException("Maximum number of consortia reached.");
            }

            var quotaValue = (consortiumDto.AssetValue + (consortiumDto.AssetValue * (consortiumDto.AdministrationFee / 100))) / consortiumDto.NumberOfInstallments;

            var consortium = new Consortium
            {
                Name = consortiumDto.Name ?? "Default Name",
                Description = consortiumDto.Description ?? "Default Description",
                AssetValue = consortiumDto.AssetValue,
                NumberOfInstallments = consortiumDto.NumberOfInstallments,
                AdministrationFee = consortiumDto.AdministrationFee,
                NumberOfQuotas = consortiumDto.NumberOfQuotas,
                QuotaValue = quotaValue,
                UserId = userId
            };

            await _consortiumRepository.AddAsync(consortium);

            for (int i = 0; i < consortium.NumberOfQuotas; i++)
            {
                var quota = new Quota
                {
                    ConsortiumId = consortium.Id,
                    Status = QuotaStatus.Disponivel
                };
                await _quotaRepository.AddAsync(quota);

                for (int j = 0; j < consortium.NumberOfInstallments; j++)
                {
                    var installment = new Installment
                    {
                        QuotaId = quota.Id,
                        Quota = quota,
                        Value = quotaValue,
                        Status = InstallmentStatus.Pendente
                    };
                    await _installmentRepository.AddAsync(installment);
                }
            }

            await _context.SaveChangesAsync();
        }

        public async Task UpdateConsortiumAsync(int consortiumId, UpdateConsortiumDto updateDto)
        {
            var consortium = await _consortiumRepository.GetByIdAsync(consortiumId);
            if (consortium == null)
            {
                throw new KeyNotFoundException("Consortium not found.");
            }

            UpdateConsortiumValues(consortium, updateDto);
            await UpdateQuotas(consortiumId, consortium, updateDto.NumberOfQuotas);
            UpdateQuotaValue(consortium, updateDto);
            await _consortiumRepository.UpdateAsync(consortium);
        }

        private static void UpdateConsortiumValues(Consortium consortium, UpdateConsortiumDto updateDto)
        {
            if (updateDto.AssetValue.HasValue)
                consortium.AssetValue = updateDto.AssetValue.Value;

            if (updateDto.NumberOfInstallments.HasValue)
                consortium.NumberOfInstallments = updateDto.NumberOfInstallments.Value;

            if (updateDto.AdministrationFee.HasValue)
                consortium.AdministrationFee = updateDto.AdministrationFee.Value;
        }

        private async Task UpdateQuotas(int consortiumId, Consortium consortium, int? numberOfQuotas)
        {
            if (!numberOfQuotas.HasValue) return;

            int currentQuotas = consortium.NumberOfQuotas;
            int newQuotas = numberOfQuotas.Value;

            if (newQuotas < currentQuotas)
            {
                var quotasToRemove = await _quotaRepository.GetLastNQuotasByConsortiumIdAsync(consortiumId, currentQuotas - newQuotas);
                foreach (var quota in quotasToRemove)
                {
                    await _quotaRepository.DeleteAsync(quota.Id);
                }
            }
            else if (newQuotas > currentQuotas)
            {
                for (int i = 0; i < newQuotas - currentQuotas; i++)
                {
                    var quota = new Quota
                    {
                        ConsortiumId = consortium.Id,
                        Status = QuotaStatus.Disponivel
                    };
                    await _quotaRepository.AddAsync(quota);
                }
            }

            consortium.NumberOfQuotas = newQuotas;
        }

        private static void UpdateQuotaValue(Consortium consortium, UpdateConsortiumDto updateDto)
        {
            if (updateDto.QuotaValue.HasValue)
            {
                consortium.QuotaValue = updateDto.QuotaValue.Value;
                consortium.AdministrationFee = CalculateAdministrationFee(consortium.AssetValue, consortium.QuotaValue, consortium.NumberOfInstallments);
            }
            else
            {
                consortium.QuotaValue = (consortium.AssetValue + (consortium.AssetValue * (consortium.AdministrationFee / 100))) / consortium.NumberOfInstallments;
            }
        }

        private static decimal CalculateAdministrationFee(decimal assetValue, decimal quotaValue, int numberOfInstallments)
        {
            return (((quotaValue * numberOfInstallments) - assetValue) / assetValue) * 100;
        }

        public async Task<bool> IsUserOwnerOfConsortiumAsync(Guid userId, int consortiumId)
        {
            var consortium = await _consortiumRepository.GetByIdAsync(consortiumId);
            return consortium != null && consortium.UserId == userId;
        }

        public async Task<IEnumerable<QuotaDto>> GetQuotasByConsortiumIdAsync(int consortiumId, Guid userId)
        {
            var isOwner = await IsUserOwnerOfConsortiumAsync(userId, consortiumId);
            if (!isOwner)
            {
                throw new UnauthorizedAccessException("Você não tem permissão para acessar as cotas deste consórcio.");
            }

            var quotas = await _quotaRepository.GetByConsortiumIdAsync(consortiumId);

            return quotas.Select(q => new QuotaDto
            {
                Id = q.Id,
                ConsortiumId = q.ConsortiumId,
                Status = q.Status.ToString()
            });
        }

        public async Task<IEnumerable<ConsortiumDto>> GetConsortiaByUserIdAsync(Guid userId)
        {
            var consortia = await _consortiumRepository.GetConsortiaByUserIdAsync(userId);
            return consortia.Select(c => new ConsortiumDto(
                c.Name ?? "Nome Padrão",
                c.Description ?? "Descrição Padrão"
            )
            {
                Id = c.Id,
                AssetValue = c.AssetValue,
                NumberOfInstallments = c.NumberOfInstallments,
                AdministrationFee = c.AdministrationFee,
                NumberOfQuotas = c.NumberOfQuotas,
                QuotaValue = c.QuotaValue
            });
        }

        public async Task DeleteConsortiumAsync(int consortiumId)
        {
            var consortium = await _consortiumRepository.GetByIdAsync(consortiumId);
            if (consortium == null)
            {
                throw new KeyNotFoundException("Consortium not found.");
            }

            await _consortiumRepository.DeleteAsync(consortiumId);
        }
    }
}