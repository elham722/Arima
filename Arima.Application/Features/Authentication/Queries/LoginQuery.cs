using Arima.Applications.DTOs.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arima.Applications.Features.Authentication.Queries
{
    public class LoginQuery : IRequest<AuthResultDto>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
