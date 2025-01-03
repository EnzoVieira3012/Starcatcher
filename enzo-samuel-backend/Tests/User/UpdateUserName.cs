using Xunit;
using Moq;
using System;
using System.Threading.Tasks;
using API.Application.Services;
using API.Domain.Entities;
using API.Domain.Interfaces;
using Microsoft.Extensions.Configuration;

public class UpdateUserNameTests
{
    private readonly Mock<IUserRepository> _mockUserRepository;
    private readonly AuthService _authService;

    public UpdateUserNameTests()
    {
        _mockUserRepository = new Mock<IUserRepository>();
        _authService = new AuthService(_mockUserRepository.Object, new Mock<IConfiguration>().Object);
    }

    [Fact]
    public async Task UpdateUserName_Should_Update_Name_When_User_Exists()
    {
        var userId = Guid.NewGuid();
        var newName = "New User Name";
        var user = new User { Id = userId, Name = "Old User Name" };

        _mockUserRepository.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync(user);

        await _authService.UpdateUserName(userId, newName);

        _mockUserRepository.Verify(repo => repo.UpdateAsync(It.Is<User>(u => u.Name == newName)), Times.Once);
    }

    [Fact]
    public async Task UpdateUserName_Should_Throw_Exception_When_User_Not_Found()
    {
        var userId = Guid.NewGuid();
        var newName = "New User Name";

        _mockUserRepository.Setup(repo => repo.GetByIdAsync(userId)).ReturnsAsync((User?)null);

        await Assert.ThrowsAsync<Exception>(() => _authService.UpdateUserName(userId, newName));
    }
}