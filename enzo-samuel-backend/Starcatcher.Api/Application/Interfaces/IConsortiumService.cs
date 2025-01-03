using Starcatcher.Api.Application.DTO;
using Starcatcher.Api.Domain.Entities;

namespace Starcatcher.Api.Application.Services
{
    public interface IConsortiumService
    {
        IEnumerable<ConsortiumDto> GetAllConsortium();
        ConsortiumDto GetConsortiumId(int id);
        ConsortiumDto CreateConsortium(CreationConsortiumDto consortiumDto);
    }
}