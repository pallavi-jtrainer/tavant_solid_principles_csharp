using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo.services.payment
{
    internal class UPIPaymentService : IPaymentStrategy
    {

        public void Pay(double amount) {
            Console.WriteLine($"Paying {amount} by UPI");
        }
    }
}
