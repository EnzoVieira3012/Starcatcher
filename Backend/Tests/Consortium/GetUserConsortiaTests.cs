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

public class ConsortiumControllerGetUserConsortiaTests
{
    private readonly Mock<IConsortiumService> _mockConsortiumService;
    private readonly ConsortiumController _controller;

    public ConsortiumControllerGetUserConsortiaTests()
    {
        _mockConsortiumService = new Mock<IConsortiumService>();
        _controller = new ConsortiumController(_mockConsortiumService.Object);

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
    public async Task GetUserConsortia_Should_Return_OkObjectResult_With_Consortia()
    {
        var userId = Guid.NewGuid();
        var consortia = new List<ConsortiumDto>
        {
            new ConsortiumDto("Consortium 1", "Description 1")
            {
                Id = 1,
                AssetValue = 10000,
                NumberOfInstallments = 10,
                AdministrationFee = 5,
                NumberOfQuotas = 100,
                QuotaValue = 1100
            },
            new ConsortiumDto("Consortium 2", "Description 2")
            {
                Id = 2,
                AssetValue = 20000,
                NumberOfInstallments = 20,
                AdministrationFee = 3,
                NumberOfQuotas = 200,
                QuotaValue = 2300
            }
        };

        _mockConsortiumService.Setup(service => service.GetConsortiaByUserIdAsync(It.IsAny<Guid>()))
            .ReturnsAsync(consortia);

        var result = await _controller.GetUserConsortia();

        var okResult = Assert.IsType<OkObjectResult>(result);
        var returnedConsortia = Assert.IsType<List<ConsortiumDto>>(okResult.Value);
        Assert.Equal(2, returnedConsortia.Count);
    }
}