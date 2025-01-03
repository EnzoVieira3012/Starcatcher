using Xunit;
using Moq;
using Starcatcher.Api.Domain.Repositories;
using Starcatcher.Api.Common;
using Starcatcher.Api.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Collections.Generic;

public class UserUtilsTest
{
    private readonly Mock<IHttpContextAccessor> _mockHttpContextAccessor;
    private readonly Mock<IUserRepository> _mockUserRepository;
    private readonly UserUtils _userUtils;

    public UserUtilsTest()
    {
        _mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
        _mockUserRepository = new Mock<IUserRepository>();
        _userUtils = new UserUtils(_mockHttpContextAccessor.Object, _mockUserRepository.Object);
    }

    [Fact]
    public void GetAuthenticatedUser_ShouldReturnUser()
    {
        var user = new User 
        {
            UserId = 1,
            Name = "Test User",
            Email = "test@example.com",
            Password = "password123",
            Wallet = new Wallet 
            {
                WalletId = 1,
                Balance = 1000,
                UserId = 1,
                User = null
            }
        };

        var claims = new List<Claim> { new Claim(ClaimTypes.Email, user.Email) };
        var identity = new ClaimsIdentity(claims, "TestAuthType");
        var principal = new ClaimsPrincipal(identity);
        var context = new DefaultHttpContext { User = principal };
        _mockHttpContextAccessor.Setup(a => a.HttpContext).Returns(context);
        _mockUserRepository.Setup(r => r.GetUserByEmail(It.IsAny<string>())).Returns(user);

        var result = _userUtils.GetAuthenticatedUser();

        Assert.Equal(user.Email, result.Email);
    }
}