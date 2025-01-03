using Xunit;
using Moq;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using API.Application.DTOs;
using API.Application.Services;
using API.Interfaces.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

public class CreateClientTest
{
    private readonly Mock<IClientService> _mockClientService;
    private readonly ClientController _controller;

    public CreateClientTest()
    {
        _mockClientService = new Mock<IClientService>();
        _controller = new ClientController(_mockClientService.Object);

        var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
        {
            new Claim(ClaimTypes.Name, Guid.NewGuid().ToString())
        }, "mock"));

        _controller.ControllerContext = new ControllerContext
        {
            HttpContext = new DefaultHttpContext { User = user }
        };
    }

    [Fact]
    public async Task CreateClient_Should_Return_Ok_When_Success()
    {
        var clientDto = new CreateClientDto { Name = "Test Client" };

        var result = await _controller.CreateClient(clientDto);

        _mockClientService.Verify(service => service.CreateClientAsync(clientDto, It.IsAny<Guid>()), Times.Once);
        Assert.IsType<OkObjectResult>(result);
    }
}