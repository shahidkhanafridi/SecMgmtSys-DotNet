using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApi.Data.Interfaces
{
    public interface IApiResponse
    {

    }
    public class ApiResponse : IApiResponse
    {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public object? Data { get; set; }
        public ApiResponse()
        {
            this.IsSuccess= true;
            this.Message = string.Empty;
            this.Data = null;
        }
    }
}
