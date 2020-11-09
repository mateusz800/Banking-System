using System;
using Microsoft.AspNetCore.Identity;

namespace AuthService.Entities
{
    public class Account : IdentityUser
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}
