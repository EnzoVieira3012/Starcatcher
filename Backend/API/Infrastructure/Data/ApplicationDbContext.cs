using Microsoft.EntityFrameworkCore;
using API.Domain.Entities;

namespace API.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Consortium> Consortia { get; set; } = null!;
        public DbSet<Quota> Quotas { get; set; } = null!;
        public DbSet<Installment> Installments { get; set; } = null!;
        public DbSet<Client> Clients { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Quota>()
                .HasOne(q => q.Consortium)
                .WithMany(c => c.Quotas)
                .HasForeignKey(q => q.ConsortiumId);

            modelBuilder.Entity<Quota>()
                .HasMany(q => q.Installments)
                .WithOne(i => i.Quota)
                .HasForeignKey(i => i.QuotaId);

            modelBuilder.Entity<Quota>()
                .HasOne(q => q.Client)
                .WithMany()
                .HasForeignKey(q => q.ClientId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}