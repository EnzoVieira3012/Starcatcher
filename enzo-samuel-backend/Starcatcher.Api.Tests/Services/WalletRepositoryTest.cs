using Xunit;
using Microsoft.EntityFrameworkCore;
using Starcatcher.Api.Infrastructure.Repositories;
using Starcatcher.Api.Domain.Entities;
using Starcatcher.Infrastructure.Data;
using System.Linq;

public class WalletRepositoryTest
{
    [Fact]
    public void Credit_ShouldUpdateWalletBalance()
    {
        var options = new DbContextOptionsBuilder<DatabaseContext>()
            .UseInMemoryDatabase("TestDatabase")
            .Options;

        using (var context = new DatabaseContext(options))
        {
            var user = new User 
            {
                UserId = 1,
                Name = "Test User",
                Email = "test@example.com",
                Password = "password123"
            };

            var wallet = new Wallet
            {
                WalletId = 1,
                Balance = 500,
                UserId = 1,
                User = user
            };

            context.Wallets.Add(wallet);
            context.SaveChanges();

            var repository = new WalletRepository(context);
            wallet.Balance += 500;
            repository.Credit(wallet);

            var updatedWallet = context.Wallets.FirstOrDefault(w => w.WalletId == 1);
            Assert.Equal(1000, updatedWallet.Balance);
        }
    }
}