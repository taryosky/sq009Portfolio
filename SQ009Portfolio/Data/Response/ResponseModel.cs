using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQ009Portfolio.Data.Response
{
    public class ResponseModel<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Dictionary<string, string> Errors { get; set; }
        public T Data { get; set; }
    }
}
