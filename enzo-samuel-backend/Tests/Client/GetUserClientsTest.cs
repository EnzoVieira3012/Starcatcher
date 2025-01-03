using Xunit;
using Moq;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using API.Application.DTOs;
using API.Application.Services;
using API.Interfaces.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

public class GetUserClientsTest
{
    private readonly Mock<IClientService> _mockClientService;
    private readonly ClientController _controller;

    public GetUserClientsTest()
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
    public async Task GetUserClients_Should_Return_Ok_With_Clients()
    {
        _mockClientService.Setup(service => service.GetClientsByUserIdAsync(It.IsAny<Guid>()))
            .ReturnsAsync(new List<ClientDto> { new ClientDto { Id = 1, Name = "Client 1" } });

        var result = await _controller.GetUserClients();

        var okResult = Assert.IsType<OkObjectResult>(result);
        var clients = Assert.IsType<List<ClientDto>>(okResult.Value);
        Assert.Single(clients);
    }
}