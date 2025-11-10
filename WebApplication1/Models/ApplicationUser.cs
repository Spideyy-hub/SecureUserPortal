using Microsoft.AspNetCore.Identity;

namespace SecureUserPortal.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Extra secure fields (validated)
        public string? FullName { get; set; }
    }
}
