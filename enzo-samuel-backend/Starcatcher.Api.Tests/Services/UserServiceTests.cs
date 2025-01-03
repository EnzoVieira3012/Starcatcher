using Xunit;
using Moq;
using Starcatcher.Api.Application.Services; 
using Starcatcher.Api.Domain.Repositories;
using Starcatcher.Api.Application.DTO; 
using Starcatcher.Api.Domain.Entities;
using Starcatcher.Api.Common;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

namespace Starcatcher.Api.Tests.Services
{
    public class UserServiceTests
    {
        private readonly Mock<IUserRepository> _mockUserRepository;
        private readonly Mock<IWalletRepository> _mockWalletRepository;
        private readonly Mock<IHttpContextAccessor> _mockHttpContextAccessor;
        private readonly Mock<UserUtils> _mockUserUtils;
        private readonly IUserService _userService;

        public UserServiceTests()
        {
            _mockUserRepository = new Mock<IUserRepository>();
            _mockWalletRepository = new Mock<IWalletRepository>();
            _mockHttpContextAccessor = new Mock<IHttpContextAccessor>();
            _mockUserUtils = new Mock<UserUtils>(_mockHttpContextAccessor.Object, _mockUserRepository.Object);
            _userService = new UserService(_mockUserRepository.Object, _mockWalletRepository.Object, _mockUserUtils.Object);
        }

        [Fact]
        public void GetAllUsers_ShouldReturnAllUsers()
        {
            var fakeUsers = new List<User> { new User { Name = "Test User", Email = "test@example.com", Password = "password" } };
            _mockUserRepository.Setup(repo => repo.GetUsers()).Returns(fakeUsers);

            var result = _userService.GetAllUsers();

            Assert.Equal(fakeUsers.Count, result.Count());
        }

        [Fact]
        public void CreateUser_ShouldAddUser()
        {
            var newUser = new CreationUserDto { Name = "Test User", Email = "test@example.com", Password = "password" };
            var userEntity = new User { Name = "Test User", Email = "test@example.com", Password = "password" };

            _mockUserRepository.Setup(repo => repo.Add(It.IsAny<User>())).Returns(userEntity);

            var result = _userService.CreateUser(newUser);

            Assert.Equal(userEntity.Email, result.Email);
            _mockUserRepository.Verify(repo => repo.Add(It.IsAny<User>()), Times.Once);
        }
    }
}