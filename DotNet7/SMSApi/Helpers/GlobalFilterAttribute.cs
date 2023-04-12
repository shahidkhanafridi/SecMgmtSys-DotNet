using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SMSApi.Helpers
{
    public class GlobalFilterAttribute : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var ctrlName = context.RouteData.Values["controller"];
            var actnName = context.RouteData.Values["action"];
            var routePath = Path.Combine(ctrlName.ToString(), actnName.ToString());
            
            context.Result = new BadRequestObjectResult(new ApiResponse { IsSuccess = false, Message = context.Exception.Message });
        }
    }
}
