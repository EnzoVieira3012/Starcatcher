using Xunit;
using Microsoft.EntityFrameworkCore;
using Starcatcher.Api.Infrastructure.Repositories;
using Starcatcher.Api.Domain.Entities;
using Starcatcher.Infrastructure.Data;
using System.Linq;

namespace Starcatcher.Api.Tests.Services
{
    public class QuotaRepositoryTest
    {
        [Fact]
        public void TestQuotaRepositoryGetAll()
        {
            var options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseInMemoryDatabase("TestDatabase")
                .Options;

            using (var context = new DatabaseContext(options))
            {
                context.Quotas.RemoveRange(context.Quotas);
                context.SaveChanges();

                context.Quotas.Add(new Quota { QuotaNumber = "123", Value = 1000m, Status = ConsortiumStatus.Open, ConsortiumId = 1, UserId = 1 });
                context.SaveChanges();

                var repository = new QuotaRepository(context);
                var quotas = repository.GetAllQuotas().ToList();

                Assert.Single(quotas);
                Assert.Equal("123", quotas[0].QuotaNumber);
            }
        }

        [Fact]
        public void GetQuotasByUserId_ShouldReturnCorrectQuotas()
        {
            var options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseInMemoryDatabase("TestDatabase")
                .Options;

            using (var context = new DatabaseContext(options))
            {
                context.Quotas.RemoveRange(context.Quotas);
                context.SaveChanges();

                var userId = 1;
                context.Quotas.AddRange(
                    new Quota { QuotaNumber = "Q1", Value = 1000m, Status = ConsortiumStatus.Open, ConsortiumId = 1, UserId = userId },
                    new Quota { QuotaNumber = "Q2", Value = 1500m, Status = ConsortiumStatus.Open, ConsortiumId = 1, UserId = userId },
                    new Quota { QuotaNumber = "Q3", Value = 2000m, Status = ConsortiumStatus.Open, ConsortiumId = 2, UserId = 2 }
                );
                context.SaveChanges();

                var repository = new QuotaRepository(context);
                var quotas = repository.GetQuotasByUserId(userId).ToList();

                Assert.Equal(2, quotas.Count);
                Assert.All(quotas, q => Assert.Equal(userId, q.UserId));
            }
        }
    }
}