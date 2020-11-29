using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AuthTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankAccountController : Controller {

        public BankAccountController()
        {

        }

        [HttpGet]
        public IActionResult doSomething([FromHeader] Guid AccountId)
        {
            
            return Ok(AccountId);
        }

    }
}
