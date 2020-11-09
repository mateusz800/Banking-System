using System;
using System.ComponentModel.DataAnnotations;

namespace AuthService.Models
{
    public class LoginModel
    {
        [Required]
        public string Login { get; private set; }
        [Required]
        public string Password { get; private set; }
        [Required]
        public string FirstName { get; private set; }
        [Required]
        public string LastName { get; private set; }
    }
}
