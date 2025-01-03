using Xunit;
using Moq;
using System;
using System.Threading.Tasks;
using API.Application.Services;
using API.Domain.Entities;
using API.Domain.Interfaces;
using Microsoft.Extensions.Configuration;

public class UpdateEmailTests
{
    private readonly Mock<IUserRepository> _mockUserRepository;
    private readonly AuthService _authService;

    public UpdateEmailTests()
    {
        _mockUserRepository = new Mock<IUserRepository>();
        _authService = new AuthService(_mockUserRepository.Object, new Mock<IConfiguration>().Object);
    }

    [Fact]
    public async Task UpdateEmail_Should_Update_Email_When_User_Exists()
    {
        var userId = Guid.NewGuid();
        var newEmail = "newemail@example.com";
        var user = new User { Id = userId, Email = "oldemail@example.com" };

        _mockUserRepository.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync(user);

        await _authService.UpdateEmail(userId, newEmail);

        _mockUserRepository.Verify(repo => repo.UpdateAsync(It.Is<User>(u => u.Email == newEmail)), Times.Once);
    }

    [Fact]
    public async Task UpdateEmail_Should_Throw_Exception_When_User_Not_Found()
    {
        var userId = Guid.NewGuid();
        var newEmail = "newemail@example.com";

        _mockUserRepository.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync((User?)null);

        await Assert.ThrowsAsync<Exception>(() => _authService.UpdateEmail(userId, newEmail));
    }
}