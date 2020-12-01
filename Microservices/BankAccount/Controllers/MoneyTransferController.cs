using System;
using System.Threading.Tasks;
using BankAccountService.CommandsAndQueries.CreateBankAccount;
using BankAccountService.CommandsAndQueries.CreateTransfer;
using BankAccountService.CommandsAndQueries.GetAccountBalance;
using BankAccountService.Common.Exceptions;
using BankAccountService.Common.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BankAccountService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoneyTransferController : Controller
    {

        private IMediator _mediator;

        public MoneyTransferController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> makeTransfer([FromHeader] Guid AccountId, [FromBody] MoneyTransferModel transfer)
        {
            try
            {
                var response = await _mediator.Send(new CreateMoneyTransferCommand(AccountId, transfer));
                return Ok(response);
            }
            catch (BankAccountNotFoundException e)
            {
                return BadRequest(e.Message);
            }
            catch (BalanceTooLowException e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
