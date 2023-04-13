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
        public object ErrorDetail { get; set; }
        public ApiResponse()
        {
            this.IsSuccess = true;
            this.Message = string.Empty;
            this.Data = null;
        }
    }
    public class ApiResponsePaging : ApiResponse
    {
        public int RecordsTotal { get; set; }
        public int RecordsFiltered { get; set; }
        public int PageNum { get; set; }
        public int PageSize { get; set; }
        public ApiResponsePaging()
        {
            this.RecordsTotal = 0;
            this.RecordsFiltered = 0;
            this.PageNum = 0;
            this.PageSize = 0;
        }
    }
    public class ErrorDetail
    {
        public string DataField { get; set; }
        public string ErrorMessage { get; set; }
    }
}
