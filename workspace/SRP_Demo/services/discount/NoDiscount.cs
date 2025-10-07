using SRP_Demo.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo.services.discount
{
    internal class NoDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(Product product) {
            return product.Price;
        }
             

    }
}
