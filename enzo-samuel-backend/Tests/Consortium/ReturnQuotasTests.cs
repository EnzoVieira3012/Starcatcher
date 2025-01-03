using Xunit;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Application.Services;
using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Infrastructure.Data;

public class ConsortiumServiceTests
{
    private readonly Mock<IQuotaRepository> _mockQuotaRepository;
    private readonly Mock<IConsortiumRepository> _mockConsortiumRepository;
    private readonly Mock<IInstallmentRepository> _mockInstallmentRepository;
    private readonly ApplicationDbContext _dbContext;
    private readonly ConsortiumService _consortiumService;

    public ConsortiumServiceTests()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _dbContext = new ApplicationDbContext(options);

        _mockQuotaRepository = new Mock<IQuotaRepository>();
        _mockConsortiumRepository = new Mock<IConsortiumRepository>();
        _mockInstallmentRepository = new Mock<IInstallmentRepository>();

        _consortiumService = new ConsortiumService(
            _mockConsortiumRepository.Object,
            _mockQuotaRepository.Object,
            _mockInstallmentRepository.Object,
            _dbContext
        );
    }

    [Fact]
    public async Task GetQuotasByConsortiumIdAsync_ShouldReturnQuotas()
    {
        int consortiumId = 1;
        Guid userId = Guid.NewGuid();

        var quotas = new List<Quota>
        {
            new Quota { Id = 1, ConsortiumId = consortiumId, Status = QuotaStatus.Disponivel },
            new Quota { Id = 2, ConsortiumId = consortiumId, Status = QuotaStatus.Vinculada }
        };

        _mockQuotaRepository.Setup(repo => repo.GetByConsortiumIdAsync(consortiumId))
            .ReturnsAsync(quotas);

        _mockConsortiumRepository.Setup(repo => repo.GetByIdAsync(consortiumId))
            .ReturnsAsync(new Consortium { Id = consortiumId, UserId = userId });

        var result = await _consortiumService.GetQuotasByConsortiumIdAsync(consortiumId, userId);

        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.Contains(result, q => q.Id == 1 && q.Status == QuotaStatus.Disponivel.ToString());
        Assert.Contains(result, q => q.Id == 2 && q.Status == QuotaStatus.Vinculada.ToString());
    }
}