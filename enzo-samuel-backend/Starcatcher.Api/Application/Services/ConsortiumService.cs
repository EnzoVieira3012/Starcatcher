using Starcatcher.Api.Application.DTO;
using Starcatcher.Api.Domain.Entities;
using Starcatcher.Api.Domain.Repositories;

namespace Starcatcher.Api.Application.Services
{
    public class ConsortiumService(IConsortiumRepository consortiumRepository, IQuotaRepository quotaRepository) : IConsortiumService
    {
        private readonly IConsortiumRepository _consortiumRepository = consortiumRepository;
        private readonly IQuotaRepository _quotaRepository = quotaRepository;

        public IEnumerable<ConsortiumDto> GetAllConsortium()
        {
            return _consortiumRepository.GetAllConsortiums().Select(ConsortiumDto.FromEntity).ToList();
        }

        public ConsortiumDto GetConsortiumId(int id)
        {
            return ConsortiumDto.FromEntity(_consortiumRepository.GetConsortiumById(id)!);
        }

        public ConsortiumDto CreateConsortium(CreationConsortiumDto consortiumDto)
        {
            var consortium = consortiumDto.ToEntity();
            var createdConsortium = _consortiumRepository.CreateConsortium(consortium);

            for (int i = 1; i <= consortiumDto.QuotaQuantity; i++)
            {
                var totalQuotaValue = consortiumDto.AssetValue / consortiumDto.QuotaQuantity;
                var administrationFee = totalQuotaValue * consortiumDto.AdministrationFee / 100;
                var quotaValue = totalQuotaValue + administrationFee;

                var quota = new Quota
                {
                    QuotaNumber = $"{createdConsortium.ConsortiumId}-{i}",
                    Value = quotaValue,
                    Status = ConsortiumStatus.Open,
                    ConsortiumId = createdConsortium.ConsortiumId
                };

                _quotaRepository.CreateQuota(quota);
            }

            return ConsortiumDto.FromEntity(createdConsortium);
        }
    }
}