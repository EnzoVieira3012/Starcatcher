using Microsoft.EntityFrameworkCore;
using Starcatcher.Api.Domain.Entities;

namespace Starcatcher.Infrastructure.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Consortium> Consortia { get; set; } = null!;
    public DbSet<Quota> Quotas { get; set; } = null!;
    public DbSet<Wallet> Wallets { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        ConfigureEntities(modelBuilder);
        SeedConsortiums(modelBuilder);
    }

    private static void ConfigureEntities(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Quota>()
            .Property(q => q.Value)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<Wallet>()
            .Property(w => w.Balance)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<Consortium>()
            .Property(c => c.AssetValue)
            .HasColumnType("decimal(18,2)");

        modelBuilder.Entity<Quota>()
            .HasOne(q => q.Consortium)
            .WithMany(c => c.Quotas)
            .HasForeignKey(q => q.ConsortiumId);

        modelBuilder.Entity<Quota>()
            .HasOne(q => q.User)
            .WithMany(u => u.Quotas)
            .HasForeignKey(q => q.UserId);

        modelBuilder.Entity<Wallet>()
            .HasOne(w => w.User)
            .WithOne(u => u.Wallet)
            .HasForeignKey<Wallet>(w => w.UserId);
    }

    private static void SeedConsortiums(ModelBuilder modelBuilder)
    {
        var consortiumDescriptions = GetConsortiumDescriptions();
        var currentDateTime = DateTime.Now;
        int quotaIdCounter = 1;

        foreach (ConsortiumType type in Enum.GetValues(typeof(ConsortiumType)))
        {
            var consortiumId = (int)type + 1;

            var entityType = modelBuilder.Model.FindEntityType(typeof(Consortium));
            if (entityType != null)
            {
                var seedData = entityType.GetSeedData();
                if (seedData != null && !seedData.Any(x => (int?)x["ConsortiumId"] == consortiumId))
                {
                    var consortium = CreateConsortium(type, consortiumDescriptions, currentDateTime, consortiumId);
                    modelBuilder.Entity<Consortium>().HasData(consortium);

                    for (int i = 1; i <= consortium.QuotaQuantity; i++)
                    {
                        var totalQuotaValue = CalculateQuotaValue(consortium);
                        modelBuilder.Entity<Quota>().HasData(
                            new Quota
                            {
                                QuotaId = quotaIdCounter++,
                                QuotaNumber = $"{consortiumId}-{i}",
                                Value = totalQuotaValue,
                                Status = ConsortiumStatus.Open,
                                CreatedAt = currentDateTime,
                                ConsortiumId = consortiumId
                            }
                        );
                    }
                }
            }
        }
    }

    private static Consortium CreateConsortium(ConsortiumType type, Dictionary<ConsortiumType, string> descriptions, DateTime currentDateTime, int consortiumId)
    {
        return new Consortium
        {
            ConsortiumId = consortiumId,
            Type = type,
            Description = $"Consórcio para {descriptions[type]}",
            CreatedAt = currentDateTime,
            AssetValue = GetAssetValue(type),
            QuotaQuantity = GetQuotaQuantity(type),
            AdministrationFee = GetAdministrationFee(type)
        };
    }

    private static decimal CalculateQuotaValue(Consortium consortium)
    {
        decimal quotaValue = consortium.AssetValue / consortium.QuotaQuantity;
        decimal administrationFee = quotaValue * consortium.AdministrationFee / 100;
        return quotaValue + administrationFee;
    }

    private static Dictionary<ConsortiumType, string> GetConsortiumDescriptions()
    {
        return new Dictionary<ConsortiumType, string>
        {
            { ConsortiumType.PopularCar, "Carros Populares" },
            { ConsortiumType.LuxuryCar, "Carros Luxuosos" },
            { ConsortiumType.PopularMotorcycle, "Motos Populares" },
            { ConsortiumType.ResidentialProperty, "Imóveis Residenciais" },
            { ConsortiumType.InternashionalTravel, "Viagens Internacionais" },
            { ConsortiumType.NashionalTravel, "Viagens Nacionais" },
            { ConsortiumType.PropertyRenovation, "Reforma de Imóveis" },
            { ConsortiumType.EletronicsDevice, "Equipamentos Eletrônicos" }
        };
    }

    private static decimal GetAssetValue(ConsortiumType type)
    {
        return type switch
        {
            ConsortiumType.PopularCar => 35000,
            ConsortiumType.LuxuryCar => 120000,
            ConsortiumType.PopularMotorcycle => 12000,
            ConsortiumType.ResidentialProperty => 50000,
            ConsortiumType.InternashionalTravel => 30000,
            ConsortiumType.NashionalTravel => 15000,
            ConsortiumType.PropertyRenovation => 50000,
            ConsortiumType.EletronicsDevice => 10000,
            _ => 0
        };
    }

    private static int GetQuotaQuantity(ConsortiumType type)
    {
        return type switch
        {
            ConsortiumType.PopularCar => 36,
            ConsortiumType.LuxuryCar => 48,
            ConsortiumType.PopularMotorcycle => 24,
            ConsortiumType.ResidentialProperty => 120,
            ConsortiumType.InternashionalTravel => 24,
            ConsortiumType.NashionalTravel => 18,
            ConsortiumType.PropertyRenovation => 36,
            ConsortiumType.EletronicsDevice => 18,
            _ => 0
        };
    }

    private static int GetAdministrationFee(ConsortiumType type)
    {
        return type switch
        {
            ConsortiumType.PopularCar => 15,
            ConsortiumType.LuxuryCar => 12,
            ConsortiumType.PopularMotorcycle => 10,
            ConsortiumType.ResidentialProperty => 10,
            ConsortiumType.InternashionalTravel => 14,
            ConsortiumType.NashionalTravel => 10,
            ConsortiumType.PropertyRenovation => 13,
            ConsortiumType.EletronicsDevice => 18,
            _ => 0
        };
    }
}