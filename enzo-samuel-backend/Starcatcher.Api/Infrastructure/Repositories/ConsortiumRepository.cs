using Starcatcher.Api.Domain.Repositories;
using Starcatcher.Infrastructure.Data;
using Starcatcher.Api.Common.Exceptions;
using Starcatcher.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Starcatcher.Api.Infrastructure.Repositories
{
    public class ConsortiumRepository(DatabaseContext context) : IConsortiumRepository
    {
        private readonly DatabaseContext _context = context;

        public IEnumerable<Consortium> GetAllConsortiums()
        {
            return _context.Consortia.Include(c => c.Quotas);
        }

        public Consortium? GetConsortiumById(int consortiumId)
        {
            return _context.Consortia.Include(c => c.Quotas).FirstOrDefault(c => c.ConsortiumId == consortiumId) ?? throw new ConsortiumNotFoundException();
        }

        public Consortium CreateConsortium(Consortium consortium)
        {
            var newConsortium = _context.Consortia.Add(consortium);
            _context.SaveChanges();
            return newConsortium.Entity;
        }
    }
}