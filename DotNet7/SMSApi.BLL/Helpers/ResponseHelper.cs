using SMSApi.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApi.BLL.Helpers
{
    public static class ResponseHelper
    {
        public static ApiResponse Success(object data)
        {
            ApiResponse ar = new() { IsSuccess = true, Data = data, Message = string.Empty };
            return ar;
        }
        public static ApiResponse Success(string message)
        {
            ApiResponse ar = new() { IsSuccess = false, Data = null, Message = message };
            return ar;
        }
        public static ApiResponse Success(object data, string message)
        {
            ApiResponse ar = new() { IsSuccess = false, Data = data, Message = message };
            return ar;
        }
        public static ApiResponse SuccessWithError(object data)
        {
            ApiResponse ar = new() { IsSuccess = true, Data = data, Message = string.Empty };
            return ar;
        }
        public static ApiResponse SuccessWithError(string message)
        {
            ApiResponse ar = new() { IsSuccess = true, Data = null, Message = message };
            return ar;
        }
        public static ApiResponse SuccessWithError(object data, string message)
        {
            ApiResponse ar = new() { IsSuccess = true, Data = data, Message = message };
            return ar;
        }
        public static ApiResponsePaging SuccessPaging(object data, int recordsTotal, string message)
        {
            ApiResponsePaging ar = new() { IsSuccess = false, Data = data, RecordsTotal = recordsTotal, RecordsFiltered = recordsTotal, Message = message };
            return ar;
        }

        public static ApiResponse Error(string message)
        {
            ApiResponse ar = new() { IsSuccess = false, Data = null, Message = message };
            return ar;
        }
        public static ApiResponse Error(object data)
        {
            ApiResponse ar = new() { IsSuccess = false, Data = data };
            return ar;
        }
        public static ApiResponse Error(object data, string message)
        {
            ApiResponse ar = new() { IsSuccess = false, Data = data, Message = message };
            return ar;
        }
        public static ApiResponse Error(bool isSuccess,object data, string message)
        {
            ApiResponse ar = new() { IsSuccess = isSuccess, Data = data, Message = message };
            return ar;
        }
    }
}
