using Xunit;
using Moq;
using System.Threading.Tasks;
using API.Application.Services;
using API.Interfaces.Controllers;
using Microsoft.AspNetCore.Mvc;

public class DeleteClientTest
{
    private readonly Mock<IClientService> _mockClientService;
    private readonly ClientController _controller;

    public DeleteClientTest()
    {
        _mockClientService = new Mock<IClientService>();
        _controller = new ClientController(_mockClientService.Object);
    }

    [Fact]
    public async Task DeleteClient_Should_Return_Ok_When_Success()
    {
        int clientId = 1;

        var result = await _controller.DeleteClient(clientId);

        _mockClientService.Verify(service => service.DeleteClientAsync(clientId), Times.Once);
        Assert.IsType<OkObjectResult>(result);
    }
}