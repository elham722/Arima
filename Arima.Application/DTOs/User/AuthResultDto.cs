using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arima.Applications.DTOs.User
{
    public class AuthResultDto
    {
        public string Token { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }
    }
}
