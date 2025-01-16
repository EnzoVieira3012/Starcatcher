using Xunit;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Application.DTOs;
using API.Application.Services;
using API.Domain.Entities;
using API.Domain.Interfaces;

public class InstallmentServiceListTests
{
    private readonly Mock<IInstallmentRepository> _mockInstallmentRepository;
    private readonly Mock<IQuotaService> _mockQuotaService;
    private readonly InstallmentService _installmentService;

    public InstallmentServiceListTests()
    {
        _mockInstallmentRepository = new Mock<IInstallmentRepository>();
        _mockQuotaService = new Mock<IQuotaService>();
        
        _installmentService = new InstallmentService(_mockInstallmentRepository.Object, _mockQuotaService.Object);
    }

    [Fact]
    public async Task GetInstallmentsByQuotaIdAsync_ShouldReturnCorrectInstallments()
    {
        int quotaId = 1;
        var installments = new List<Installment>
        {
            new Installment { Id = 1, QuotaId = quotaId, Value = 100, Status = InstallmentStatus.Pendente },
            new Installment { Id = 2, QuotaId = quotaId, Value = 100, Status = InstallmentStatus.Pendente }
        };

        _mockInstallmentRepository.Setup(repo => repo.GetByQuotaIdAsync(quotaId))
            .ReturnsAsync(installments);

        var result = await _installmentService.GetInstallmentsByQuotaIdAsync(quotaId);

        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.All(result, i => Assert.Equal(100, i.Value));
        Assert.All(result, i => Assert.Equal("Pendente", i.Status));
    }
}