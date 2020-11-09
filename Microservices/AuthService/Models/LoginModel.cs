using System;
using System.ComponentModel.DataAnnotations;

namespace AuthService.Models
{
    public class RegistrationModel
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
