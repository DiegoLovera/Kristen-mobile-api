using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace kristen_mobile_api.Business.Exceptions
{
    public class ApiRequestException : Exception
    {
        public HttpStatusCode ErrorCode { get; set; }
        
        public ApiRequestException(HttpStatusCode errorCode) : base(String.Format("Request error code: {0}", errorCode.ToString()))
        {
            ErrorCode = errorCode;
        }
    }
}
