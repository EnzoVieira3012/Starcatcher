using Starcatcher.Api.Application.DTO;
using Starcatcher.Api.Domain.Entities;
using System.Collections.Generic;

namespace Starcatcher.Api.Application.Services
{
    public interface IQuotaService
    {
        IEnumerable<QuotaDto> GetAllQuotas();
        IEnumerable<QuotaDto> GetByConsortiumId(int consortiumId);
        QuotaDto? GetQuotaById(int id);
        QuotaDto CreateQuota(CreationQuotaDto quota);
        QuotaDto UpdateQuota(UpdateQuotaDto quota);
        void DeleteQuota(int id);
        QuotaDto BuyQuota(int id, User user);
        IEnumerable<QuotaDto> GetQuotasByUserId(int userId); // Adicionada a linha
    }
}