using Xunit;
using Microsoft.EntityFrameworkCore;
using Starcatcher.Api.Infrastructure.Repositories;
using Starcatcher.Api.Domain.Entities;
using Starcatcher.Infrastructure.Data;
using System.Linq;

public class ConsortiumRepositoryTest
{
    [Fact]
    public void GetAllConsortiums_ShouldReturnAllConsortiums()
    {
        var options = new DbContextOptionsBuilder<DatabaseContext>()
            .UseInMemoryDatabase("TestDatabase")
            .Options;

        using (var context = new DatabaseContext(options))
        {
            var consortium = new Consortium
            {
                ConsortiumId = 1,
                Type = ConsortiumType.PopularCar,
                Description = "Test Consortium",
                AssetValue = 100000,
                QuotaQuantity = 10,
                AdministrationFee = 5
            };

            context.Consortia.Add(consortium);
            context.SaveChanges();

            var repository = new ConsortiumRepository(context);
            var consortia = repository.GetAllConsortiums().ToList();

            Assert.Single(consortia);
            Assert.Equal("Test Consortium", consortia[0].Description);
        }
    }
}