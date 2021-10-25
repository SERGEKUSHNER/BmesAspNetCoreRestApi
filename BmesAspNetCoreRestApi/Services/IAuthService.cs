using BmesAspNetCoreRestApi.Messages.Request.User;
using BmesAspNetCoreRestApi.Messages.Response.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BmesAspNetCoreRestApi.Services
{
   public interface IAuthService
    {
        Task<RegisterResponse> RegisterAsync(RegisterRequest request, CancellationToken cancellationToken = default);
        Task<LogInResponse> LogInAsync(LogInRequest request, CancellationToken cancellationToken = default);
    }
}
