global using Microsoft.AspNetCore.Identity;
global using SMSApi.Models;
global using SMSApi.BLL.Helpers;
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

        [HttpPost]
        public async Task<IActionResult> CreateAsync(UserDTO model)
        {
            
            User user = this.mapper.Map<User>(model);
            IdentityResult identityResult = await userManager.CreateAsync(user, password: model.Password);
            if(identityResult.Succeeded)
            {
                this.apiResponse = ResponseHelper.Success(user, "User successfully created");
            }
            else
            {
                this.apiResponse = ResponseHelper.SuccessWithError(user, "User does not created");
            }
            return Ok(this.apiResponse);
        }

        [HttpGet]
        public ActionResult GetUser()
        {
            throw new Exception("Duplicate entries found in database");
            return null;
        }
    }
}
