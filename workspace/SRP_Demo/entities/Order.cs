using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo.entities
{
    internal class Order
    {
        public int Id { get; set; }
        public string customerEmail { get; set; } = "";
        public double total { get; set; }

        public List<Product> products { get; set; } = new List<Product>();

        public int Quantity { get; set; }

        public string PaymentType { get; set; } = "";
    }
}
