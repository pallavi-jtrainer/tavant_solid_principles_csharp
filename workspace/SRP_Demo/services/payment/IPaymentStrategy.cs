using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo.services.payment
{
    internal interface IPaymentStrategy
    {
        void Pay(double amount);
    }
}
