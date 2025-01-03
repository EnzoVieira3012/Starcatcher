using Xunit;
using Moq;
using System;
using System.Threading.Tasks;
using API.Application.Services;
using API.Domain.Entities;
using API.Domain.Interfaces;
using Microsoft.Extensions.Configuration;

public class DeleteUserTests
{
    private readonly Mock<IUserRepository> _mockUserRepository;
    private readonly AuthService _authService;

    public DeleteUserTests()
    {
        _mockUserRepository = new Mock<IUserRepository>();
        _authService = new AuthService(_mockUserRepository.Object, new Mock<IConfiguration>().Object);
    }

    [Fact]
    public async Task DeleteUser_Should_Delete_User_When_Password_Is_Correct()
    {
        var userId = Guid.NewGuid();
        var password = "correctpassword";
        var user = new User { Id = userId, PasswordHash = BCrypt.Net.BCrypt.HashPassword(password) };

        _mockUserRepository.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync(user);

        await _authService.DeleteUser(userId, password);

        _mockUserRepository.Verify(repo => repo.DeleteAsync(userId), Times.Once);
    }

    [Fact]
    public async Task DeleteUser_Should_Throw_Exception_When_Password_Is_Incorrect()
    {
        var userId = Guid.NewGuid();
        var password = "wrongpassword";
        var user = new User { Id = userId, PasswordHash = BCrypt.Net.BCrypt.HashPassword("correctpassword") };

        _mockUserRepository.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync(user);

        await Assert.ThrowsAsync<Exception>(() => _authService.DeleteUser(userId, password));
    }

    [Fact]
    public async Task DeleteUser_Should_Throw_Exception_When_User_Not_Found()
    {
        var userId = Guid.NewGuid();
        var password = "anyPassword";

        _mockUserRepository.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync((User?)null);

        await Assert.ThrowsAsync<Exception>(() => _authService.DeleteUser(userId, password));
    }
}