using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditCardPayment.Model;

namespace CreditCardPayment.MiddleWare
{
    public class ExpensivePaymentGateway :IExpensivePaymentGateway
    {
        PaymentDbContext paymentDb = new PaymentDbContext();
       public int Processpayment(PaymentDetails paydels)
        {
            paymentDb.paymentdetails.Add(paydels);
           return paymentDb.SaveChanges();
            //if(i>0)
            //    return 'Payment is Process'
        }
    }
}

