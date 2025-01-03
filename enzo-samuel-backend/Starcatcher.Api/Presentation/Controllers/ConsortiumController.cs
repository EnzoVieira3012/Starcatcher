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
    public class ConsortiumController(IConsortiumService consortiumService) : ControllerBase
    {
        private readonly IConsortiumService _consortiumController = consortiumService;

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ConsortiumDto>), 200)]
        public IActionResult GetAll()
        {
            return Ok(_consortiumController.GetAllConsortium());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ConsortiumDto), 200)]
        [ProducesResponseType(404)]
        public IActionResult GetConsortiumById(int id)
        {
            var consortium = _consortiumController.GetConsortiumId(id);
            return Ok(consortium);
        }

        [HttpPost]
        [ProducesResponseType(typeof(ConsortiumDto), 201)]
        public IActionResult Create([FromBody] CreationConsortiumDto consortiumDto)
        {
            var createdConsortium = _consortiumController.CreateConsortium(consortiumDto);
            return Created("", createdConsortium);
        }
    }
}