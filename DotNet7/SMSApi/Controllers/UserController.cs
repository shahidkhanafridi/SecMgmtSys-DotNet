global using Microsoft.AspNetCore.Identity;
global using SMSApi.Models;
global using SMSApi.BLL.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMSApi.Data.Entities;
using AutoMapper;

namespace SMSApi.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(string id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpGet("username/{username}")]
        public async Task<IActionResult> GetUserByUsername(string username)
        {
            var user = await _userService.GetUserByUsernameAsync(username);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            return Ok(users);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserDto userDto)
        {
            try
            {
                var user = new User { UserName = userDto.Username, Email = userDto.Email };
                await _userService.CreateUserAsync(user, userDto.Password);
            }
            catch (Exception ex)
            {
                throw;
            }
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(string id, UserDto userDto)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            // Update the properties of the user based on the provided userDto object
            user.UserName = userDto.Username;
            user.Email = userDto.Email;
            // Update other properties as needed

            await _userService.UpdateUserAsync(user);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _userService.GetUserByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            await _userService.DeleteUserAsync(user);
            return Ok();
        }
    }

}
