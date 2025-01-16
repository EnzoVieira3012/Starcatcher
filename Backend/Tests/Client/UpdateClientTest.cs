using Xunit;
using Moq;
using System.Threading.Tasks;
using API.Application.DTOs;
using API.Application.Services;
using API.Interfaces.Controllers;
using Microsoft.AspNetCore.Mvc;

public class UpdateClientTest
{
    private readonly Mock<IClientService> _mockClientService;
    private readonly ClientController _controller;

    public UpdateClientTest()
    {
        _mockClientService = new Mock<IClientService>();
        _controller = new ClientController(_mockClientService.Object);
    }

    [Fact]
    public async Task UpdateClient_Should_Return_Ok_When_Success()
    {
        int clientId = 1;
        var clientDto = new UpdateClientDto { Name = "Updated Client" };

        var result = await _controller.UpdateClient(clientId, clientDto);

        _mockClientService.Verify(service => service.UpdateClientAsync(clientId, clientDto), Times.Once);
        Assert.IsType<OkObjectResult>(result);
    }
}