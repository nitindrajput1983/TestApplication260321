using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditCardPayment.Model;

namespace CreditCardPayment.MiddleWare
{
    interface IExpensivePaymentGateway
    {
        int Processpayment(PaymentDetails paydels);
    }
}
