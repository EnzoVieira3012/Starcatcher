using Xunit;
using Moq;
using Starcatcher.Api.Application.Services;
using Starcatcher.Api.Domain.Repositories;
using Starcatcher.Api.Application.DTO;
using Starcatcher.Api.Domain.Entities;
using Starcatcher.Api.Common.Exceptions;
using System.Collections.Generic;
using System.Linq;

public class QuotaServiceTest
{
    private readonly Mock<IQuotaRepository> _mockQuotaRepository;
    private readonly Mock<IWalletRepository> _mockWalletRepository;
    private readonly Mock<IConsortiumRepository> _mockConsortiumRepository;
    private readonly IQuotaService _quotaService;

    public QuotaServiceTest()
    {
        _mockQuotaRepository = new Mock<IQuotaRepository>();
        _mockWalletRepository = new Mock<IWalletRepository>();
        _mockConsortiumRepository = new Mock<IConsortiumRepository>();

        _mockConsortiumRepository.Setup(r => r.GetConsortiumById(It.IsAny<int>()))
            .Returns(new Consortium
            {
                ConsortiumId = 1,
                Type = ConsortiumType.PopularCar,
                Description = "Test Consortium",
                AssetValue = 100000,
                QuotaQuantity = 10,
                AdministrationFee = 5
            });

        _quotaService = new QuotaService(_mockQuotaRepository.Object, _mockWalletRepository.Object, _mockConsortiumRepository.Object);
    }

    [Fact]
    public void CreateQuota_ShouldAddQuota()
    {
        var quotaDto = new CreationQuotaDto { QuotaNumber = "123", Value = 1000, Status = ConsortiumStatus.Open, ConsortiumId = 1 };
        var quota = quotaDto.ToEntity();
        _mockQuotaRepository.Setup(r => r.CreateQuota(It.IsAny<Quota>())).Returns(quota);

        var result = _quotaService.CreateQuota(quotaDto);

        Assert.Equal(quotaDto.QuotaNumber, result.QuotaNumber);
    }

    [Fact]
    public void BuyQuota_ShouldThrowException_WhenInsufficientBalance()
    {
        var user = new User
        {
            UserId = 1,
            Name = "Test User",
            Email = "test@example.com",
            Password = "password123",
            Wallet = new Wallet
            {
                WalletId = 1,
                Balance = 500,
                UserId = 1,
                User = null
            }
        };

        var quota = new Quota
        {
            QuotaId = 1,
            QuotaNumber = "Q123",
            Value = 1000,
            Status = ConsortiumStatus.Open,
            ConsortiumId = 1
        };

        _mockQuotaRepository.Setup(r => r.GetQuotaById(It.IsAny<int>())).Returns(quota);
        _mockWalletRepository.Setup(r => r.GetWalletById(It.IsAny<int>())).Returns(user.Wallet);

        Assert.Throws<InsufficientBalanceException>(() => _quotaService.BuyQuota(1, user));
    }

    [Fact]
    public void GetQuotasByUserId_ShouldReturnQuotasForUser()
    {
        var userId = 1;
        var quotas = new List<Quota>
        {
            new Quota { QuotaId = 1, QuotaNumber = "Q1", UserId = userId, Status = ConsortiumStatus.Open, ConsortiumId = 1 },
            new Quota { QuotaId = 2, QuotaNumber = "Q2", UserId = userId, Status = ConsortiumStatus.Open, ConsortiumId = 1 }
        };

        _mockQuotaRepository.Setup(repo => repo.GetQuotasByUserId(userId)).Returns(quotas);

        var result = _quotaService.GetQuotasByUserId(userId);

        Assert.Equal(quotas.Count, result.Count());
        Assert.All(result, q => Assert.Equal(userId, q.UserId));
    }
}