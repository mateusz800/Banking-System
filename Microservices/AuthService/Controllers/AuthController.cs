using System;
using System.Threading.Tasks;
using AuthService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController
    {
        private readonly UserManager<Entities.Account> userManager;

        public AuthController(UserManager<Entities.Account> userManager)
        {
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Test()
        {
            return new OkResult();
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationModel model)
        {
            var userExists = await userManager.FindByNameAsync(model.Login);
            if (userExists != null)
            {
                // user already exists
                return new BadRequestResult();
            }

            Entities.Account user = new Entities.Account()
            {
                UserName = model.Login,

                SecurityStamp = Guid.NewGuid().ToString()
            };
            var result = await userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                // something went wrong
                return new StatusCodeResult(500);

            }
            return new OkResult();
        }
    }
}
