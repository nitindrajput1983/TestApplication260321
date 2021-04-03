using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CreditCardPayment.Model;
using CreditCardPayment.MiddleWare;

namespace CreditCardPayment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : ControllerBase
    {
      

        private readonly ILogger<PaymentController> _logger;
        IExpensivePaymentGateway IExpensivepay;
        ICheapPaymentGateway IcheapPay;

        public PaymentController(ILogger<PaymentController> logger)
        {
            _logger = logger;
        }

       
        [HttpPost]
        public int ProcessPayment([FromBody] PaymentDetails Paydetails)
        {
            int status = 0;
            IExpensivepay = new ExpensivePaymentGateway();
            IcheapPay = new CheapPaymentGateway();
            if(Paydetails.Amount<20)
            {
               status= IcheapPay.Processpayment(Paydetails);
            }
            else if(Paydetails.Amount>20 && Paydetails.Amount<=500)
            {
                status= IExpensivepay.Processpayment(Paydetails);
            }
            return status;
        }
    }
}
