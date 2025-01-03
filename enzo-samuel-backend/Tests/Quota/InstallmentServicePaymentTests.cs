using Xunit;
using Moq;
using System.Threading.Tasks;
using API.Application.Services;
using API.Domain.Entities;
using API.Domain.Interfaces;

public class InstallmentServicePaymentTests // Certifique-se de que o nome é único
{
    private readonly Mock<IInstallmentRepository> _mockInstallmentRepository;
    private readonly Mock<IQuotaService> _mockQuotaService;
    private readonly InstallmentService _installmentService;

    public InstallmentServicePaymentTests() // Construtor diferente
    {
        _mockInstallmentRepository = new Mock<IInstallmentRepository>();
        _mockQuotaService = new Mock<IQuotaService>();
        
        _installmentService = new InstallmentService(_mockInstallmentRepository.Object, _mockQuotaService.Object);
    }

    [Fact]
    public async Task MarkInstallmentAsPaidAsync_ShouldUpdateInstallmentStatusToPaid() // Nome do método diferente
    {
        int installmentId = 1;
        var installment = new Installment { Id = installmentId, Status = InstallmentStatus.Pendente };

        _mockInstallmentRepository.Setup(repo => repo.GetByIdAsync(installmentId))
            .ReturnsAsync(installment);

        await _installmentService.MarkInstallmentAsPaidAsync(installmentId);

        _mockInstallmentRepository.Verify(repo => repo.UpdateAsync(It.Is<Installment>(
            i => i.Id == installmentId && i.Status == InstallmentStatus.Pago)), Times.Once);
        
        _mockQuotaService.Verify(service => service.CheckAndUpdateQuotaStatusIfPaid(installment.QuotaId), Times.Once);
    }
}