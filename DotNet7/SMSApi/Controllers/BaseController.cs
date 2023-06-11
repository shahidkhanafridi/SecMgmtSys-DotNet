global using SMSApi.Data.Interfaces;
global using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SMSApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected readonly IMapper mapper;
        protected IApiResponse apiResponse;
        public BaseController(IMapper mapper)
        {
            this.mapper = mapper;
        }
    }
}
