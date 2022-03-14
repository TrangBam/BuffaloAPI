using Abstractions.Interfaces;
using DTOs.Buffalo.User;
using Infrastructure.ApiControllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Buffalo.Controllers
{
    [Produces("application/json")]
    [Route("training/employees")]
    [Authorize]
    public class UserController : ApiControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllUsers()
        {
            var result = await _userService.GetAllUsersAsync();
            return Success(result);
        }

        [HttpGet("{id:guid}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetUser([FromRoute] Guid id)
        {
            var result = await _userService.GetUserAsync(id);
            return Success(result);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDto dto)
        {
            await _userService.CreateUserAsync(dto);
            return Success();
        }

        [HttpPut]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateUser([FromBody] UserDto dto)
        {
            await _userService.UpdateUserAsync(dto);
            return Success();
        }

        [HttpDelete("{id:guid}")]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteUser([FromRoute] Guid id)
        {
            await _userService.DeleteUserAsync(id);
            return Success();
        }
    }
}
