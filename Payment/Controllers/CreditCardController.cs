using DataAccess.Models;
using DataAccess.Repo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.Controllers
{
    [ApiController]
    //HI
    public class CreditCardController : ControllerBase
    {
        CreditCardDbContext db;
        public CreditCardController()
        {
            db = new CreditCardDbContext();
        }
        [HttpPost]
        [Route("api/checkcard")]
        public string CheckCard(CreditCard creditCard)
        {
            var status= CreditCardManager.CheckCard(creditCard);
            if (status)
            {
                MockPaymentService.Make1EuroCentPayment(creditCard);
                return "successful";
            }
            else
            {
                return "failed";
            }
           
        }
        
        [HttpGet]
        [Route("get/details")]
        public IEnumerable<CreditCard> Get()
        {
            return db.CreditCards.ToList();
        }

    }
}
