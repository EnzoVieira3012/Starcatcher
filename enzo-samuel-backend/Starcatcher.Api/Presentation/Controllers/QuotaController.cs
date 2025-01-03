using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Starcatcher.Api.Application.DTO;
using Starcatcher.Api.Application.Services;
using Starcatcher.Api.Common.Exceptions;
using Starcatcher.Api.Domain.Entities;

namespace Starcatcher.Api.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class QuotaController(IQuotaService quotaService, IUserService userService) : ControllerBase
    {
        private readonly IQuotaService _quotaService = quotaService;
        private readonly IUserService _userService = userService;

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<QuotaDto>), 200)]
        public IActionResult GetAll()
        {
            return Ok(_quotaService.GetAllQuotas());
        }

        [HttpGet("consortium/{consortiumId}")]
        [ProducesResponseType(typeof(IEnumerable<QuotaDto>), 200)]
        [ProducesResponseType(404)]
        public IActionResult GetByConsortiumId(int consortiumId)
        {
            return Ok(_quotaService.GetByConsortiumId(consortiumId));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(QuotaDto), 200)]
        [ProducesResponseType(404)]
        public IActionResult GetQuotaById(int id)
        {
            var quota = _quotaService.GetQuotaById(id);
            return Ok(quota);
        }

        [HttpGet("user/{userId}")]
        [ProducesResponseType(typeof(IEnumerable<QuotaDto>), 200)]
        [ProducesResponseType(404)]
        public IActionResult GetQuotasByUserId(int userId)
        {
            var quotas = _quotaService.GetQuotasByUserId(userId);
            return Ok(quotas);
        }

        [HttpPost]
        [ProducesResponseType(typeof(QuotaDto), 201)]
        [ProducesResponseType(409)]
        public IActionResult Create([FromBody] CreationQuotaDto quota)
        {
            return Created("", _quotaService.CreateQuota(quota));
        }

        [HttpPost("buy/{id}")]
        [ProducesResponseType(typeof(QuotaDto), 201)]
        [ProducesResponseType(404)]
        public IActionResult Buy(int id)
        {
            var token = HttpContext.User.Identity as ClaimsIdentity;
            var email = token?.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value ?? "";
            User? user = _userService.GetUserByEmail(email!) ?? throw new UserNotFoundException();
            return Created("", _quotaService.BuyQuota(id, user));
        }

        [HttpPut]
        [ProducesResponseType(typeof(QuotaDto), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(409)]
        public IActionResult Update([FromBody] UpdateQuotaDto quota)
        {
            return Ok(_quotaService.UpdateQuota(quota));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        public IActionResult Delete(int id)
        {
            _quotaService.DeleteQuota(id);
            return NoContent();
        }
    }
}