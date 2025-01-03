using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data;

namespace API.Infrastructure.Repositories
{
    public class ConsortiumRepository : IConsortiumRepository
    {
        private readonly ApplicationDbContext _context;

        public ConsortiumRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Consortium consortium)
        {
            await _context.Consortia.AddAsync(consortium);
            await _context.SaveChangesAsync();
        }

        public async Task<int> GetNextConsortiumNumber(Guid userId)
        {
            var lastConsortium = await _context.Consortia
                .Where(c => c.UserId == userId)
                .OrderByDescending(c => c.Id)
                .FirstOrDefaultAsync();

            return lastConsortium == null ? 1 : lastConsortium.Id + 1;
        }

        public async Task<IEnumerable<Consortium>> GetConsortiaByUserIdAsync(Guid userId)
        {
            return await _context.Consortia
                .Where(c => c.UserId == userId)
                .ToListAsync();
        }

        public async Task<Consortium?> GetByIdAsync(int consortiumId)
        {
            var consortium = await _context.Consortia.FindAsync(consortiumId);
            return consortium;
        }

        public async Task UpdateAsync(Consortium consortium)
        {
            _context.Consortia.Update(consortium);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int consortiumId)
        {
            var consortium = await _context.Consortia.FindAsync(consortiumId);
            
            if (consortium == null)
            {
                throw new KeyNotFoundException("Consortium not found.");
            }

            _context.Consortia.Remove(consortium);
            await _context.SaveChangesAsync();
        }
    }
}