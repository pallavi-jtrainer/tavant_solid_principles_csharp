using SRP_Demo.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo.services.shipping
{
    internal interface ShippingStrategy
    {
        double CalculateShippingCost(Order order);
    }
}
