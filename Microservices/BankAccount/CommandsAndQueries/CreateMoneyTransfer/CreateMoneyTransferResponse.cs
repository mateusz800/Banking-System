using System;
using System.Net;
using BankAccountService.Common.Models;

namespace BankAccountService.CommandsAndQueries.CreateTransfer
{
    public class CreateMoneyTransferResponse : ResponseModel
    {
        public CreateMoneyTransferResponse(HttpStatusCode status) : base(status)
        {
        }
    }
}