using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCardPayment.MiddleWare
{
    interface ICheapPaymentGateway
    {
        int Processpayment(PaymentDetails paydels);
    }
}
