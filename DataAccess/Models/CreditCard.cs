using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Models
{
    public class CreditCard
    {
        public string HolderName { get; set; }
        [Key]
        public string CardNumber { get; set; }
        public int CVV { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
