
using Arima.Applications.DTOs.User;
using Arima.Applications.Features.Authentication.Commands;
using Arima.Applications.Features.Authentication.Queries;

namespace Arima.Applications.Contracts.Identity
{
    public interface IAuthService
    {
        Task<AuthResultDto> RegisterAsync(RegisterCommand command);
        Task<AuthResultDto> LoginAsync(LoginQuery query);
    }
}
