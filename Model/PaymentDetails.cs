using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCardPayment
{
    public class PaymentDetails
    {
        public int? PaymentId { get; set; }
        [Required, CreditCard]
        public string CerditcardNo { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z ]*$")]
        public string CardHold { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }
        [StringLength(3, ErrorMessage = "It only takes three digit")]
        public string SecurityCode { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public decimal Amount { get; set; }
    }
}