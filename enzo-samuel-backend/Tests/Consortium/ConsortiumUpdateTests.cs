using Microsoft.EntityFrameworkCore;
using Xunit;
using Moq;
using System.Threading.Tasks;
using API.Application.Services;
using API.Application.DTOs;
using API.Domain.Entities;
using API.Domain.Interfaces;
using System;
using API.Infrastructure.Data;

public class ConsortiumUpdateTests
{
    private readonly Mock<IConsortiumRepository> _mockConsortiumRepository;
    private readonly Mock<IQuotaRepository> _mockQuotaRepository;
    private readonly Mock<IInstallmentRepository> _mockInstallmentRepository;
    private readonly ApplicationDbContext _dbContext;
    private readonly ConsortiumService _consortiumService;

    public ConsortiumUpdateTests()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _dbContext = new ApplicationDbContext(options);

        _mockConsortiumRepository = new Mock<IConsortiumRepository>();
        _mockQuotaRepository = new Mock<IQuotaRepository>();
        _mockInstallmentRepository = new Mock<IInstallmentRepository>();

        _consortiumService = new ConsortiumService(
            _mockConsortiumRepository.Object,
            _mockQuotaRepository.Object,
            _mockInstallmentRepository.Object,
            _dbContext
        );
    }

    [Fact]
    public async Task UpdateConsortium_Should_Update_Consortium_When_Valid()
    {
        var consortiumId = 1;
        var updateDto = new UpdateConsortiumDto
        {
            AssetValue = 15000,
            NumberOfInstallments = 12,
            AdministrationFee = 3,
            NumberOfQuotas = 150
        };

        var consortium = new Consortium
        {
            Id = consortiumId,
            UserId = Guid.NewGuid(),
            AssetValue = 10000,
            NumberOfInstallments = 10,
            AdministrationFee = 5,
            NumberOfQuotas = 100,
            QuotaValue = 1100
        };

        _mockConsortiumRepository.Setup(repo => repo.GetByIdAsync(consortiumId))
            .ReturnsAsync(consortium);

        _mockConsortiumRepository.Setup(repo => repo.UpdateAsync(It.IsAny<Consortium>()))
            .Returns(Task.CompletedTask);

        await _consortiumService.UpdateConsortiumAsync(consortiumId, updateDto);

        _mockConsortiumRepository.Verify(repo => repo.UpdateAsync(It.Is<Consortium>(
            c => c.AssetValue == updateDto.AssetValue &&
                 c.NumberOfInstallments == updateDto.NumberOfInstallments &&
                 c.AdministrationFee == updateDto.AdministrationFee &&
                 c.NumberOfQuotas == updateDto.NumberOfQuotas
        )), Times.Once);
    }
}