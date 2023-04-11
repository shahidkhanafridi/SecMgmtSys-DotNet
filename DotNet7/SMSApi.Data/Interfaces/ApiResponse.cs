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
        public bool IsError { get; set; }
        public string? Message { get; set; }
        public object? Data { get; set; }
        public ApiResponse(object data)
        {
            this.IsError= false;
            this.Data = data;
        }
        public ApiResponse(string? message, object? data)
        {
            this.IsError= false;
            this.Message = message;
            this.Data = data;
        }
        public ApiResponse(bool isError, string? message, object? data)
        {
            this.IsError = isError;
            this.Message = message;
            this.Data = data;
        }
    }
}
