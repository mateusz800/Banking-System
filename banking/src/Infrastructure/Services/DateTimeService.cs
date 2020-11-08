using banking.Application.Common.Interfaces;
using System;

namespace banking.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
