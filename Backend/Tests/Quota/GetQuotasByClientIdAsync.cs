using Xunit;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Application.Services;
using API.Application.DTOs;

public class QuotaServiceTests
{
    private readonly Mock<IQuotaRepository> _mockQuotaRepository;
    private readonly Mock<IInstallmentRepository> _mockInstallmentRepository;
    private readonly Mock<IClientRepository> _mockClientRepository;
    private readonly QuotaService _quotaService;

    public QuotaServiceTests()
    {
        _mockQuotaRepository = new Mock<IQuotaRepository>();
        _mockInstallmentRepository = new Mock<IInstallmentRepository>();
        _mockClientRepository = new Mock<IClientRepository>();
        
        _quotaService = new QuotaService(
            _mockQuotaRepository.Object, 
            _mockInstallmentRepository.Object, 
            _mockClientRepository.Object
        );
    }

    [Fact]
    public async Task GetQuotasByClientIdAsync_ShouldReturnQuotasForClient()
    {
        int clientId = 1;
        var quotas = new List<Quota>
        {
            new Quota { Id = 1, ConsortiumId = 10, Status = QuotaStatus.Vinculada, ClientId = clientId },
            new Quota { Id = 2, ConsortiumId = 20, Status = QuotaStatus.Vinculada, ClientId = clientId }
        };

        _mockQuotaRepository.Setup(repo => repo.GetByClientIdAsync(clientId))
            .ReturnsAsync(quotas);

        var result = await _quotaService.GetQuotasByClientIdAsync(clientId);

        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.Contains(result, q => q.Id == 1 && q.ConsortiumId == 10 && q.Status == "Vinculada");
        Assert.Contains(result, q => q.Id == 2 && q.ConsortiumId == 20 && q.Status == "Vinculada");
    }

    [Fact]
    public async Task GetQuotasByClientIdAsync_ShouldReturnEmptyList_WhenNoQuotasForClient()
    {
        int clientId = 1;

        _mockQuotaRepository.Setup(repo => repo.GetByClientIdAsync(clientId))
            .ReturnsAsync(new List<Quota>());

        var result = await _quotaService.GetQuotasByClientIdAsync(clientId);

        Assert.NotNull(result);
        Assert.Empty(result);
    }
}