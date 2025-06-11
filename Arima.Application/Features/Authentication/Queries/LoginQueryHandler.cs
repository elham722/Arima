using Arima.Applications.Contracts.Identity;
using Arima.Applications.DTOs.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arima.Applications.Features.Authentication.Queries
{
    public class LoginQueryHandler(IAuthService authService) : IRequestHandler<LoginQuery, AuthResultDto>
    {
        private readonly IAuthService _authService = authService;

        public Task<AuthResultDto> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            return _authService.LoginAsync(request);
        }
    }
}
