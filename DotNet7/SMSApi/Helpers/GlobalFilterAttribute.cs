using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SMSApi.Helpers
{
    public class GlobalFilterAttribute : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string? ctrlName = (string)context.RouteData.Values["controller"];
            string? actnName = (string)context.RouteData.Values["action"];
            string routePath = Path.Combine(ctrlName.ToString(), actnName.ToString());

            context.Result = new BadRequestObjectResult(new ApiResponse { IsSuccess = false, Message = context.Exception.Message, ErrorDetail = context.Exception });
        }
    }
}
