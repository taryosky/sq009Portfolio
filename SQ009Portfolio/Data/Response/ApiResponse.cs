using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SQ009Portfolio.Data.Response
{
    public class ApiResponse
    {
        public static ResponseModel<T> CreateResponse<T>(string message, Dictionary<string, string> errors, T data){
            return new ResponseModel<T>
            {
                Success = true,
                Errors = errors,
                Message = message,
                Data = data
            };
        }
    }
}
