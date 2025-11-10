using Xunit;
using SecureUserPortal.Models;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SecureUserPortal.Tests
{
    public class SecurityTests
    {
        [Fact]
        public void RegisterViewModel_Should_Fail_For_Invalid_Email()
        {
            var model = new RegisterViewModel { Email = "invalid", Password = "Pass123!", ConfirmPassword = "Pass123!" };
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(model, new ValidationContext(model), results, true);
            Assert.False(isValid);
        }

        [Fact]
        public void Passwords_Should_Match()
        {
            var model = new RegisterViewModel { Email = "a@b.com", Password = "Pass123!", ConfirmPassword = "Mismatch" };
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(model, new ValidationContext(model), results, true);
            Assert.False(isValid);
        }
    }
}
