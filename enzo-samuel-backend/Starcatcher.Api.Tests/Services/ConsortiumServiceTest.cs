using Xunit;
using Moq;
using Starcatcher.Api.Application.Services;
using Starcatcher.Api.Domain.Repositories;
using Starcatcher.Api.Application.DTO;
using Starcatcher.Api.Domain.Entities;
using System.Collections.Generic;

namespace Starcatcher.Api.Tests.Services
{
    public class ConsortiumServiceTest
    {
        private readonly Mock<IConsortiumRepository> _mockConsortiumRepository;
        private readonly Mock<IQuotaRepository> _mockQuotaRepository;
        private readonly IConsortiumService _consortiumService;

        public ConsortiumServiceTest()
        {
            _mockConsortiumRepository = new Mock<IConsortiumRepository>();
            _mockQuotaRepository = new Mock<IQuotaRepository>();
            _consortiumService = new ConsortiumService(_mockConsortiumRepository.Object, _mockQuotaRepository.Object);
        }

        [Fact]
        public void CreateConsortium_ShouldAddConsortiumAndQuotas()
        {
            var consortiumDto = new CreationConsortiumDto
            {
                Type = ConsortiumType.PopularCar,
                Description = "Test Consortium",
                AssetValue = 100000,
                QuotaQuantity = 10,
                AdministrationFee = 5
            };

            var consortiumEntity = consortiumDto.ToEntity();
            _mockConsortiumRepository.Setup(r => r.CreateConsortium(It.IsAny<Consortium>())).Returns(consortiumEntity);

            var result = _consortiumService.CreateConsortium(consortiumDto);

            Assert.Equal(consortiumDto.Description, result.Description);
            _mockConsortiumRepository.Verify(r => r.CreateConsortium(It.IsAny<Consortium>()), Times.Once);
            _mockQuotaRepository.Verify(r => r.CreateQuota(It.IsAny<Quota>()), Times.Exactly(consortiumDto.QuotaQuantity));
        }
    }
}