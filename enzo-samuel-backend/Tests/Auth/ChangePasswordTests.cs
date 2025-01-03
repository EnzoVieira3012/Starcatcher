using Xunit;
using Moq;
using System.Threading.Tasks;
using API.Application.Services;
using API.Application.DTOs;
using API.Domain.Entities;
using API.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

public class ChangePasswordTests
{
    private readonly Mock<IUserRepository> _mockUserRepository;
    private readonly IConfiguration _configuration;
    private readonly AuthService _authService;

    public ChangePasswordTests()
    {
        _mockUserRepository = new Mock<IUserRepository>();

        var inMemorySettings = new Dictionary<string, string?>
        {
            {"Jwt:Key", "YourVerySecureSecretKeyHereWithAtLeast32Characters"}
        };

        _configuration = new ConfigurationBuilder()
            .AddInMemoryCollection(inMemorySettings)
            .Build();

        _authService = new AuthService(_mockUserRepository.Object, _configuration);
    }

    [Fact]
    public async Task ChangePassword_Should_Update_Password_When_User_Exists()
    {
        var changePasswordDto = new ChangePasswordDto
        {
            Email = "test@example.com",
            NewPassword = "newpassword123"
        };

        var user = new User
        {
            Name = "Test User",
            Email = "test@example.com",
            PasswordHash = BCrypt.Net.BCrypt.HashPassword("oldpassword123")
        };

        _mockUserRepository.Setup(repo => repo.GetByEmailAsync(It.IsAny<string>()))
            .ReturnsAsync(user);

        await _authService.ChangePassword(changePasswordDto.Email, changePasswordDto.NewPassword);

        _mockUserRepository.Verify(repo => repo.UpdateAsync(It.IsAny<User>()), Times.Once);
    }

    [Fact]
    public async Task ChangePassword_Should_Throw_Exception_When_User_Not_Found()
    {
        var changePasswordDto = new ChangePasswordDto
        {
            Email = "nonexistent@example.com",
            NewPassword = "newpassword123"
        };

        _mockUserRepository.Setup(repo => repo.GetByEmailAsync(It.IsAny<string>()))
            .ReturnsAsync((User?)null);

        await Assert.ThrowsAsync<Exception>(() => _authService.ChangePassword(changePasswordDto.Email, changePasswordDto.NewPassword));
    }
}