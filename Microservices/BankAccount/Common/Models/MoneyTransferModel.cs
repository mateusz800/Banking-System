using System;
using System.ComponentModel.DataAnnotations;

namespace BankAccountService.Common.Models
{
    public class MoneyTransferModel
    {
        [Required]
        public Guid TargetAccountId { get; set; }
        [Required]
        public float Amount { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
