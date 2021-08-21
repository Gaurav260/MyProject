using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class CreditCardDbContext:DbContext
    {
        public CreditCardDbContext(DbContextOptions<CreditCardDbContext> options) : base(options)
        {
        }

        public CreditCardDbContext()
        {
        }

   
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("data source=GAURAVSINGH02\\SQLEXPRESS;initial catalog=POC;integrated security=True");
        public DbSet<CreditCard> CreditCards { get; set; }
    }
}
