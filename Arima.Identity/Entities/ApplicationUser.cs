
namespace Arima.Identity.Entities
{
    public class ApplicationUser :IdentityUser
    {
        public string? FullName { get; set; }
        public string? PhoneNumber { get; set; }

    }
}
