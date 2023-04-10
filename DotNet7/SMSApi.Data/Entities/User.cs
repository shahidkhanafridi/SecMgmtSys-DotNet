using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApi.Data.Entities
{
    public class User : IdentityUser
    {
        [Required]
        [MinLength(3, ErrorMessage = "Please enter valid first name")]
        public string FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; }
    }
}
