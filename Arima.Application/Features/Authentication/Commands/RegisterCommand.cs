using Arima.Applications.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Arima.Applications.Features.Authentication.Commands
{
    public class RegisterCommand : IRequest<AuthResultDto>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
