global using Microsoft.AspNetCore.Identity;
global using SMSApi.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SMSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        private readonly UserManager<IdentityUser> userManager;
        public UserController(IMapper mapper, UserManager<IdentityUser> userManager) : base(mapper)
        {
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Create(UserDTO model)
        {
            return Ok();
        }
    }
}
