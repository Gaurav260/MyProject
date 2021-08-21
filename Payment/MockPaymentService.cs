using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment
{
    public static class MockPaymentService
    {
       public static bool Make1EuroCentPayment(CreditCard card)
        {
            //This is a mockup service to make payment of 1 Euro cent
            return true;
        }
        //public static bool MakePayment(CreditCard card,double amount)
        //{
        //    return false;
        //}
    }
}
