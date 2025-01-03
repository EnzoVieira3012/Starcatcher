using Starcatcher.Api.Domain.Entities;

namespace Starcatcher.Api.Domain.Repositories
{
    public interface IConsortiumRepository
    {
        IEnumerable<Consortium> GetAllConsortiums();
        Consortium? GetConsortiumById(int consortiumId);
        Consortium CreateConsortium(Consortium consortium);
    }
}