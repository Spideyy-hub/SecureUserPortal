using System.ComponentModel.DataAnnotations;

namespace SecureUserPortal.Models
{
    public class RegisterViewModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, StringLength(50, MinimumLength = 3)]
        public string FullName { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
