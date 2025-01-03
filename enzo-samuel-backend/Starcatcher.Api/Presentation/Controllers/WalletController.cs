using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Starcatcher.Api.Application.DTO;
using Starcatcher.Api.Application.Services;

namespace Starcatcher.Api.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class WalletController(IWalletService walletService) : ControllerBase
    {
        private readonly IWalletService _walletService = walletService;

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<WalletDto>), 200)]
        public IActionResult GetAll()
        {
            return Ok(_walletService.GetWallets());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(WalletDto), 200)]
        [ProducesResponseType(404)]
        public IActionResult GetUserById(int id)
        {
            return Ok(_walletService.GetWalletById(id));
        }

        [HttpPost("credit")]
        [ProducesResponseType(typeof(WalletDto), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult Credit([FromBody] CreditBalanceWalletDto creditBalanceWalletDto)
        {
            return Ok(_walletService.Credit(creditBalanceWalletDto));
        }
    }
}