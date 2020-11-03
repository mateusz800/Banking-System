using System;
using Microsoft.EntityFrameworkCore;

namespace SupportAPI.Data
{
    public class DataContext:DbContext
    {
        // public DbSet<Account> Accounts { get; set;}
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
        }
    }
}
