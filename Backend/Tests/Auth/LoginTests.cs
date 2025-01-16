using Xunit;
using Moq;
using System.Threading.Tasks;
using API.Application.Services;
using API.Application.DTOs;
using API.Domain.Entities;
using API.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

public class LoginTests
{
    private readonly Mock<IUserRepository> _mockUserRepository;
    private readonly IConfiguration _configuration;
    private readonly AuthService _authService;

    public LoginTests()
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
    public async Task Login_Should_Return_Token_When_Credentials_Are_Valid()
    {
        var loginDto = new UserLoginDto
        {
            Email = "test@example.com",
            Password = "password123"
        };

        var user = new User
        {
            Name = "Test User",
            Email = "test@example.com",
            PasswordHash = BCrypt.Net.BCrypt.HashPassword("password123")
        };

        _mockUserRepository.Setup(repo => repo.GetByEmailAsync(It.IsAny<string>()))
            .ReturnsAsync(user); 

        var token = await _authService.Login(loginDto);

        Assert.NotNull(token);
    }

    [Fact]
    public async Task Login_Should_Throw_Exception_When_Credentials_Are_Invalid()
    {
        var loginDto = new UserLoginDto
        {
            Email = "test@example.com",
            Password = "wrongpassword"
        };

        var user = new User
        {
            Name = "Test User",
            Email = "test@example.com",
            PasswordHash = BCrypt.Net.BCrypt.HashPassword("password123")
        };

        _mockUserRepository.Setup(repo => repo.GetByEmailAsync(It.IsAny<string>()))
            .ReturnsAsync(user); 

        await Assert.ThrowsAsync<Exception>(() => _authService.Login(loginDto));
    }
}