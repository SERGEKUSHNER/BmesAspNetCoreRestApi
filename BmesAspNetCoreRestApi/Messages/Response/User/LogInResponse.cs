using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BmesAspNetCoreRestApi.Messages.Response.User
{
    public class LogInResponse : ResponseBase
    {
        public string Token { get; set; }
    }
}
