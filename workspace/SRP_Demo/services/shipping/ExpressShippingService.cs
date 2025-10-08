using SRP_Demo.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo.services.shipping
{
    internal class ExpressShippingService : ShippingStrategy
    {
        public double CalculateShippingCost(Order order)
        {
            double totalWeight = order.products.Sum(p => p.Weight);
            return 100 + (totalWeight * 25);
        }
    }
}
