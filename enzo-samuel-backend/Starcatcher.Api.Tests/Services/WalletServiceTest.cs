using Xunit;
using Moq;
using Starcatcher.Api.Application.Services;
using Starcatcher.Api.Domain.Repositories;
using Starcatcher.Api.Application.DTO;
using Starcatcher.Api.Domain.Entities;
using Starcatcher.Api.Common;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Collections.Generic;

public class WalletServiceTest
{
    private readonly Mock<IWalletRepository> _mockWalletRepository;
    private readonly Mock<IHttpContextAccessor> _mockHttpContextAccessor;
    private readonly Mock<IUserRepository> _mockUserRepository;
    private readonly UserUtils _userUtils;
    private readonly IWalletService _walletService;

    public WalletServiceTest()
    {
        _mockWalletRepository = new Mock<IWalletRepository>();
        _mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
        _mockUserRepository = new Mock<IUserRepository>();

        _userUtils = new UserUtils(_mockHttpContextAccessor.Object, _mockUserRepository.Object);

        _walletService = new WalletService(_mockWalletRepository.Object, _userUtils);
    }

    [Fact]
    public void Credit_ShouldIncreaseBalance()
    {
        var user = new User
        {
            UserId = 1,
            Name = "Test User",
            Email = "test@example.com",
            Password = "password123"
        };

        var wallet = new Wallet
        {
            WalletId = 1,
            Balance = 500,
            UserId = 1,
            User = user
        };

        user.Wallet = wallet;

        var claims = new List<Claim> { new Claim(ClaimTypes.Email, user.Email) };
        var identity = new ClaimsIdentity(claims, "TestAuthType");
        var principal = new ClaimsPrincipal(identity);
        var context = new DefaultHttpContext { User = principal };

        _mockHttpContextAccessor.Setup(a => a.HttpContext).Returns(context);
        _mockUserRepository.Setup(r => r.GetUserByEmail(user.Email)).Returns(user);
        _mockWalletRepository.Setup(r => r.GetWalletById(wallet.WalletId)).Returns(wallet);

        var creditDto = new CreditBalanceWalletDto { Amount = 500 };
        var result = _walletService.Credit(creditDto);

        Assert.Equal(1000, result.Balance);
    }
}