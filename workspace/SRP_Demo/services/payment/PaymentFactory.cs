using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo.services.payment
{
    internal class PaymentFactory
    {
        public static IPaymentStrategy GetPaymentStrategy(string type) {
            return type switch
            {
                "CreditCard" => new CreditCardPaymentService(),
                "DebitCard" => new DebitCardPaymentService(),
                "UPI" => new UPIPaymentService(),
                _ => throw new ArgumentException($"Unkown Payment Type: {type}")
            };
        }
    }
}
