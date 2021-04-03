using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditCardPayment.Model;


namespace CreditCardPayment.MiddleWare
{
    public class CheapPaymentGateway : ICheapPaymentGateway
    {
        public int Processpayment(PaymentDetails paydels)
        {
            PaymentDbContext paymentDb = new PaymentDbContext();
            paymentDb.paymentdetails.Add(paydels);
            return paymentDb.SaveChanges();
            //if(i>0)
            //    return 'Payment is Process'
        }

    }
}

