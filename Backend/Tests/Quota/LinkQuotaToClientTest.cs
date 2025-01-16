using Xunit;
using Moq;
using System.Threading.Tasks;
using API.Application.Services;
using API.Interfaces.Controllers;
using Microsoft.AspNetCore.Mvc;

public class LinkQuotaToClientTest
{
    private readonly Mock<IQuotaService> _mockQuotaService;
    private readonly QuotaController _controller;

    public LinkQuotaToClientTest()
    {
        _mockQuotaService = new Mock<IQuotaService>();
        
        var mockInstallmentService = new Mock<IInstallmentService>();

        _controller = new QuotaController(mockInstallmentService.Object, _mockQuotaService.Object);
    }

    [Fact]
    public async Task LinkQuotaToClient_Should_Return_Ok_When_Success()
    {
        int quotaId = 1;
        int clientId = 2;

        var result = await _controller.LinkQuotaToClient(quotaId, clientId);

        _mockQuotaService.Verify(service => service.LinkQuotaToClientAsync(quotaId, clientId), Times.Once);
        Assert.IsType<OkObjectResult>(result);
    }
}