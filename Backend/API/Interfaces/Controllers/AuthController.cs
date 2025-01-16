using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using API.Application.DTOs;
using API.Application.Services;

namespace API.Interfaces.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet("me")]
        [Authorize]
        public async Task<IActionResult> GetUserById()
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(new { Message = "Invalid token." });
            }

            try
            {
                var user = await _authService.GetUserByIdAsync(Guid.Parse(userId));
                if (user == null)
                {
                    return NotFound(new { Message = "User not found." });
                }

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationDto registrationDto)
        {
            try
            {
                var token = await _authService.Register(registrationDto);
                return Ok(new { Token = token });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto loginDto)
        {
            try
            {
                var token = await _authService.Login(loginDto);
                return Ok(new { Token = token });
            }
            catch (Exception ex)
            {
                return Unauthorized(new { Message = ex.Message });
            }
        }

        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto changePasswordDto)
        {
            if (string.IsNullOrEmpty(changePasswordDto.Email) || string.IsNullOrEmpty(changePasswordDto.NewPassword))
            {
                return BadRequest(new { Message = "Email and NewPassword cannot be null or empty." });
            }

            try
            {
                await _authService.ChangePassword(changePasswordDto.Email, changePasswordDto.NewPassword);
                return Ok(new { Message = "Password changed successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpPut("update-email")]
        public async Task<IActionResult> UpdateEmail([FromBody] UpdateEmailDto updateEmailDto)
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(new { Message = "Invalid token." });
            }

            try
            {
                await _authService.UpdateEmail(Guid.Parse(userId), updateEmailDto.NewEmail);
                return Ok(new { Message = "Email updated successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpPut("update-name")]
        public async Task<IActionResult> UpdateUserName([FromBody] UpdateUserNameDto updateUserNameDto)
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(new { Message = "Invalid token." });
            }

            try
            {
                await _authService.UpdateUserName(Guid.Parse(userId), updateUserNameDto.NewName);
                return Ok(new { Message = "User name updated successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpDelete("delete-account")]
        public async Task<IActionResult> DeleteAccount([FromBody] DeleteUserDto deleteUserDto)
        {
            var userId = User.FindFirstValue(ClaimTypes.Name);
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(new { Message = "Invalid token." });
            }

            try
            {
                await _authService.DeleteUser(Guid.Parse(userId), deleteUserDto.Password);
                return Ok(new { Message = "User account deleted successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }
    }
}