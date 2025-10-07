using SRP_Demo.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo.services.discount
{
    internal class DiscountCalculator
    {
        private readonly IDiscountStrategy _discountStrategy;

        public DiscountCalculator(IDiscountStrategy discountStrategy) { 
            _discountStrategy = discountStrategy;
        }

        public double CalculateDiscount(Product product) {

            return _discountStrategy.ApplyDiscount(product);

            //if (product.Category == "Electronics")
            //{
            //    return product.Price * 0.1;
            //}
            //else if (product.Category == "Stationary")
            //    return product.Price * 0.05;
            //else
            //    return product.Price;
        }
    }
}
