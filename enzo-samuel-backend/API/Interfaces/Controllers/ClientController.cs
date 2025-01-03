using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using API.Application.DTOs;
using API.Application.Services;

namespace API.Interfaces.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateClient([FromBody] CreateClientDto clientDto)
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(new { Message = "Invalid token." });
            }

            try
            {
                await _clientService.CreateClientAsync(clientDto, Guid.Parse(userId));
                return Ok(new { Message = "Client created successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetUserClients()
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(new { Message = "Invalid token." });
            }

            try
            {
                var clients = await _clientService.GetClientsByUserIdAsync(Guid.Parse(userId));
                return Ok(clients);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClient(int id, [FromBody] UpdateClientDto clientDto)
        {
            try
            {
                await _clientService.UpdateClientAsync(id, clientDto);
                return Ok(new { Message = "Client updated successfully." });
            }
            catch (KeyNotFoundException)
            {
                return NotFound(new { Message = "Client not found." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            try
            {
                await _clientService.DeleteClientAsync(id);
                return Ok(new { Message = "Client deleted successfully." });
            }
            catch (KeyNotFoundException)
            {
                return NotFound(new { Message = "Client not found." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }
    }
}