using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BmesAspNetCoreRestApi.Messages.Response
{
    public class ResponseBase
    {
        public HttpStatusCode StatusCode { get; set; }
        public List<string> Messages { get; set; }
        public ResponseBase()
        {
            Messages = new List<string>();
        }
    }
}
