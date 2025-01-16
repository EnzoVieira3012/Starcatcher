using Xunit;
using Moq;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Application.Services;
using API.Interfaces.Controllers;
using System.Collections.Generic;

public class ConsortiumControllerDeleteTests
{
    private readonly Mock<IConsortiumService> _mockConsortiumService;
    private readonly ConsortiumController _controller;

    public ConsortiumControllerDeleteTests()
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
    public async Task DeleteConsortium_Should_Call_Service_With_Correct_Parameters()
    {
        var consortiumId = 1;
        var userIdString = _controller.User.FindFirstValue(ClaimTypes.Name);
        
        if (!Guid.TryParse(userIdString, out var userId))
        {
            throw new InvalidOperationException("User ID is not valid.");
        }

        _mockConsortiumService
            .Setup(service => service.IsUserOwnerOfConsortiumAsync(userId, consortiumId))
            .ReturnsAsync(true);

        var result = await _controller.DeleteConsortium(consortiumId);

        _mockConsortiumService.Verify(service => service.DeleteConsortiumAsync(consortiumId), Times.Once);
        Assert.IsType<OkObjectResult>(result);
    }

    [Fact]
    public async Task DeleteConsortium_Should_Return_Forbidden_When_User_Is_Not_Owner()
    {
        var consortiumId = 1;
        var userIdString = _controller.User.FindFirstValue(ClaimTypes.Name);
        
        if (!Guid.TryParse(userIdString, out var userId))
        {
            throw new InvalidOperationException("User ID is not valid.");
        }

        _mockConsortiumService
            .Setup(service => service.IsUserOwnerOfConsortiumAsync(userId, consortiumId))
            .ReturnsAsync(false);

        var result = await _controller.DeleteConsortium(consortiumId);

        Assert.IsType<ForbidResult>(result);
    }

    [Fact]
    public async Task DeleteConsortium_Should_Return_NotFound_When_Consortium_Does_Not_Exist()
    {
        var consortiumId = 1;
        var userIdString = _controller.User.FindFirstValue(ClaimTypes.Name);

        if (!Guid.TryParse(userIdString, out var userId))
        {
            throw new InvalidOperationException("User ID is not valid.");
        }

        _mockConsortiumService
            .Setup(service => service.IsUserOwnerOfConsortiumAsync(userId, consortiumId))
            .ReturnsAsync(true);

        _mockConsortiumService
            .Setup(service => service.DeleteConsortiumAsync(consortiumId))
            .ThrowsAsync(new KeyNotFoundException());

        var result = await _controller.DeleteConsortium(consortiumId);

        Assert.IsType<NotFoundObjectResult>(result);
    }
}