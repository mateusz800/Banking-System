using System;
using System.Net;
using BankAccountService.Common.Models;

namespace BankAccountService.CommandsAndQueries.CreateBankAccount
{
    public class CreateBankAccountResponse:ResponseModel
    {

        public CreateBankAccountResponse(HttpStatusCode status):base(status)
        {
        }
    }
}
