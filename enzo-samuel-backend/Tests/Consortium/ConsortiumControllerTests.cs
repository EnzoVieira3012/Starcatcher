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

public class ConsortiumControllerTests
{
    private readonly Mock<IConsortiumService> _mockConsortiumService;
    private readonly ConsortiumController _controller;

    public ConsortiumControllerTests()
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
    public async Task CreateConsortium_Should_Call_Service_With_Correct_Parameters()
    {
        var dto = new CreateConsortiumDto
        {
            Name = "Test Consortium",
            Description = "Test Description",
            AssetValue = 10000,
            NumberOfInstallments = 10,
            AdministrationFee = 5,
            NumberOfQuotas = 100
        };

        var result = await _controller.CreateConsortium(dto);

        _mockConsortiumService.Verify(service => service.CreateConsortiumAsync(It.Is<CreateConsortiumDto>(
            c => c.Name == dto.Name &&
                 c.Description == dto.Description &&
                 c.AssetValue == dto.AssetValue &&
                 c.NumberOfInstallments == dto.NumberOfInstallments &&
                 c.AdministrationFee == dto.AdministrationFee &&
                 c.NumberOfQuotas == dto.NumberOfQuotas
        ), It.IsAny<Guid>()), Times.Once);

        Assert.IsType<OkObjectResult>(result);
    }
}