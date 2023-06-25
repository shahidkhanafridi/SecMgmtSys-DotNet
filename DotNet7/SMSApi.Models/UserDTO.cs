using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApi.Models
{
    public class UserDto
    {
        public string? Id { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Please enter vali first name")]
        public string FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; }

        public string? Username { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email address is invalid")]
        public string? Email { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "Please enter valid password")]
        [PasswordPropertyText(true)]
        public string Password { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
    }
}
