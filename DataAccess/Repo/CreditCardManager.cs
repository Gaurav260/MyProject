using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repo
{
    public static class CreditCardManager
    {
        public static bool CheckCard(CreditCard creditCard)
        {
            using (var context = new CreditCardDbContext())
            {
                var card = context.CreditCards.Find(creditCard.CardNumber);
                if (card != null)
                {
                    if (card.HolderName == creditCard.HolderName && card.CVV == creditCard.CVV && (DateTime.Compare(card.ExpiryDate, creditCard.ExpiryDate) == 0))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                    return false;
            }
        }
    }
}
