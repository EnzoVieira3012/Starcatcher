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
    public class ConsortiumController : ControllerBase
    {
        private readonly IConsortiumService _consortiumService;

        public ConsortiumController(IConsortiumService consortiumService)
        {
            _consortiumService = consortiumService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateConsortium([FromBody] CreateConsortiumDto consortiumDto)
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(new { Message = "Invalid token." });
            }

            try
            {
                await _consortiumService.CreateConsortiumAsync(consortiumDto, Guid.Parse(userId));
                return Ok(new { Message = "Consortium created successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetUserConsortia()
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(new { Message = "Invalid token." });
            }

            try
            {
                var consortia = await _consortiumService.GetConsortiaByUserIdAsync(Guid.Parse(userId));
                return Ok(consortia);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateConsortium(int id, [FromBody] UpdateConsortiumDto updateDto)
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(new { Message = "Invalid token." });
            }

            try
            {
                var isOwner = await _consortiumService.IsUserOwnerOfConsortiumAsync(Guid.Parse(userId), id);
                if (!isOwner)
                {
                    return Forbid();
                }

                await _consortiumService.UpdateConsortiumAsync(id, updateDto);
                return Ok(new { Message = "Consortium updated successfully." });
            }
            catch (KeyNotFoundException)
            {
                return NotFound(new { Message = "Consortium not found." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsortium(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(new { Message = "Invalid token." });
            }

            try
            {
                var isOwner = await _consortiumService.IsUserOwnerOfConsortiumAsync(Guid.Parse(userId), id);
                if (!isOwner)
                {
                    return Forbid();
                }

                await _consortiumService.DeleteConsortiumAsync(id);
                return Ok(new { Message = "Consortium deleted successfully." });
            }
            catch (KeyNotFoundException)
            {
                return NotFound(new { Message = "Consortium not found." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpGet("{consortiumId}/quotas")]
        public async Task<IActionResult> GetQuotasByConsortiumId(int consortiumId)
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(new { Message = "Invalid token." });
            }

            try
            {
                var quotas = await _consortiumService.GetQuotasByConsortiumIdAsync(consortiumId, Guid.Parse(userId));
                return Ok(quotas);
            }
            catch (UnauthorizedAccessException)
            {
                return Forbid();
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }
    }
}