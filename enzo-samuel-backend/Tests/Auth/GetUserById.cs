using Xunit;
using Moq;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using API.Application.Services;
using API.Domain.Entities;
using API.Interfaces.Controllers;

public class AuthControllerTests
{
    private readonly Mock<IAuthService> _mockAuthService;
    private readonly AuthController _controller;

    public AuthControllerTests()
    {
        _mockAuthService = new Mock<IAuthService>();
        _controller = new AuthController(_mockAuthService.Object);

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
    public async Task GetUserById_ReturnsOkResult_WithUser()
    {
        var userId = Guid.Parse(_controller.User.FindFirstValue(ClaimTypes.Name));
        var user = new User { Id = userId, Name = "Test User", Email = "test@example.com" };

        _mockAuthService.Setup(service => service.GetUserByIdAsync(userId)).ReturnsAsync(user);

        var result = await _controller.GetUserById();

        var okResult = Assert.IsType<OkObjectResult>(result);
        var returnedUser = Assert.IsType<User>(okResult.Value);
        Assert.Equal(userId, returnedUser.Id);
        Assert.Equal("Test User", returnedUser.Name);
    }

    [Fact]
    public async Task GetUserById_ReturnsNotFound_WhenUserDoesNotExist()
    {
        var userId = Guid.Parse(_controller.User.FindFirstValue(ClaimTypes.Name));

        _mockAuthService.Setup(service => service.GetUserByIdAsync(userId)).ReturnsAsync((User?)null);

        var result = await _controller.GetUserById();

        Assert.IsType<NotFoundObjectResult>(result);
    }
}