using Arima.Applications.Contracts.Identity;
using Arima.Applications.DTOs.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arima.Applications.Features.Authentication.Commands
{
    public class RegisterCommandHandler(IAuthService authService) : IRequestHandler<RegisterCommand, AuthResultDto>
    {
        private readonly IAuthService _authService = authService;

        public Task<AuthResultDto> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            return _authService.RegisterAsync(request);
        }
    }
}
