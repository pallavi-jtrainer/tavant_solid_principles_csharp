using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo.services.discount
{
    internal class DiscountFactory
    {
        public static IDiscountStrategy GetDiscountStrategy(string category) {
            return category switch
            {
                "Electronics" => new ElectronicsDiscount(),
                "Stationary" => new StationaryDiscount(),
                _ => new NoDiscount()
            };


        }
    }
}
