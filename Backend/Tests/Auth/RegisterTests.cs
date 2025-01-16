using Xunit;
using Moq;
using System.Threading.Tasks;
using API.Application.Services;
using API.Application.DTOs;
using API.Domain.Entities;
using API.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

public class RegisterTests
{
    private readonly Mock<IUserRepository> _mockUserRepository;
    private readonly IConfiguration _configuration;
    private readonly AuthService _authService;

    public RegisterTests()
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
    public async Task Register_Should_Create_User_When_Not_Exists()
    {
        var registrationDto = new UserRegistrationDto
        {
            Name = "Test User",
            Email = "test@example.com",
            Password = "password123"
        };

        _mockUserRepository.Setup(repo => repo.GetByEmailAsync(It.IsAny<string>()))
            .ReturnsAsync((User?)null);

        var token = await _authService.Register(registrationDto);

        Assert.NotNull(token);
        _mockUserRepository.Verify(repo => repo.AddAsync(It.IsAny<User>()), Times.Once);
    }

    [Fact]
    public async Task Register_Should_Throw_Exception_When_User_Exists()
    {
        var registrationDto = new UserRegistrationDto
        {
            Name = "Test User",
            Email = "test@example.com",
            Password = "password123"
        };

        var existingUser = new User
        {
            Name = "Existing User",
            Email = "test@example.com"
        };

        _mockUserRepository.Setup(repo => repo.GetByEmailAsync(It.IsAny<string>()))
            .ReturnsAsync(existingUser);

        await Assert.ThrowsAsync<Exception>(() => _authService.Register(registrationDto));
    }
}