using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApi.Models
{
    public class UserDTO
    {
        public string? Id { get; set; }
        [Required]
        [MinLength(3,ErrorMessage ="Please enter vali first name")]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Email address is invalid")]
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
