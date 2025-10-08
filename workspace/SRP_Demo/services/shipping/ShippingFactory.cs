using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo.services.shipping
{
    internal class ShippingFactory
    {
        public static ShippingStrategy GetShippingStrategy(string type) {
            return type switch
            {
                "Standard" => new StandardShippingService(),
                "Free" => new FreeShippingService(),
                "Express" => new ExpressShippingService(),
                _ => throw new ArgumentException($"Unknown Shipping Type: {type}")
            };
        }
    }
}
