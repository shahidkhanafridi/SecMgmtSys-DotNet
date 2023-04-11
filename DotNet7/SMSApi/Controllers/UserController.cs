global using Microsoft.AspNetCore.Identity;
global using SMSApi.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMSApi.Data.Entities;

namespace SMSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        private readonly UserManager<User> userManager;
        public UserController(IMapper mapper, UserManager<User> userManager) : base(mapper)
        {
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> CreateAsync(UserDTO model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    User user = this.mapper.Map<User>(model);
                    IdentityResult identityResult = await userManager.CreateAsync(user, password: model.Password);
                    if(identityResult.Succeeded)
                    {
                        return new CreatedAtActionResult(nameof(CreateAsync), "", new { id = 0 }, user);
                    }
                    else
                    {
                        return null;
                    }
                    
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return Ok();
        }
    }
}
