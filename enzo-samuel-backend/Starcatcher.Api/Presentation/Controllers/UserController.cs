using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Starcatcher.Api.Application.DTO;
using Starcatcher.Api.Application.Services;
using Starcatcher.Api.Common;

namespace Starcatcher.Api.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class UserController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<UserDto>), 200)]
        public IActionResult GetAll()
        {
            return Ok(_userService.GetAllUsers());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(UserDto), 200)]
        [ProducesResponseType(404)]
        public IActionResult GetUserById(int id)
        {
            var user = _userService.GetUserById(id);
            return Ok(user);
        }

        [HttpPost]
        [AllowAnonymous]
        [ProducesResponseType(typeof(UserDto), 201)]
        [ProducesResponseType(409)]
        public IActionResult Create([FromBody] CreationUserDto user)
        {
            return Created("", _userService.CreateUser(user));
        }

        [HttpPut]
        [ProducesResponseType(typeof(UserDto), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(409)]
        public IActionResult Update([FromBody] UpdateUserDto user)
        {
            return Ok(_userService.UpdateUser(user));
        }

        [HttpDelete]
        [ProducesResponseType(204)]
        public IActionResult Delete()
        {
            _userService.DeleteUser();
            return NoContent();
        }

        [HttpPost("login")]
        [AllowAnonymous]
        [ProducesResponseType(typeof(LoginDtoResponse), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Login([FromBody] LoginDtoRequest credentials)
        {
            return Ok(_userService.Login(credentials));
        }
    }
}