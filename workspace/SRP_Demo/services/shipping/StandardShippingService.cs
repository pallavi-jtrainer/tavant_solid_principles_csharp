using SRP_Demo.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo.services.shipping
{
    internal class StandardShippingService : ShippingStrategy
    {
        public double CalculateShippingCost(Order order)
        {
            double totalWeight = order.products.Sum(p => p.Weight);
            return 50 + (totalWeight * 10);
        }
    }
}
