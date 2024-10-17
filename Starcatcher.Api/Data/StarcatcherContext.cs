using Microsoft.EntityFrameworkCore;
using Starcatcher.Api.Models;

namespace Starcatcher.Api.Data
{
    public class StarcatcherContext : DbContext
    {
        public StarcatcherContext(DbContextOptions<StarcatcherContext> options)
            : base(options)
        {
        }

        public DbSet<Cota> Cotas { get; set; }
    }
}