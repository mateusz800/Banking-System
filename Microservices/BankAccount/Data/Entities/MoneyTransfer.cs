using System;

namespace BankAccountService.Data.Entities
{
    public class MoneyTransfer
    {
        public int Id { get; set; }
        public Guid AccountFrom { get; set; }
        public Guid AccountTo { get; set; }
        public float Amount { get; set; }

        public MoneyTransfer(Guid accountFrom, Guid accountTo, float amount)
        {
            AccountFrom = accountFrom;
            AccountTo = accountTo;
            Amount = amount;
        }
    }
}
