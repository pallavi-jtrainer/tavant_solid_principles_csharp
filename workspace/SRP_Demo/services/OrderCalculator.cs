using SRP_Demo.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo.services
{
    internal class OrderCalculator
    {
        public OrderCalculator() { }

        public double CalculateOrderTotal(Order order) {
            return order.products.Sum(p => p.Price);
        }
    }
}
