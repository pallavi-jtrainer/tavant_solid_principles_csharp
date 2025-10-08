using SRP_Demo.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo.services.shipping
{
    internal class FreeShippingService : ShippingStrategy
    {
        public double CalculateShippingCost(Order order) {
            if (order.total < 500) return 25;

            return 0;
        }
    }
}
