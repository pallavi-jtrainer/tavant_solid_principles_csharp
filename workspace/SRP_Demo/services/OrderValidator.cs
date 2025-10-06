using SRP_Demo.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo.services
{
    internal class OrderValidator
    {
        public void Validate(Order order) {
            if (order.total <= 0) {
                throw new Exception("Invalid Order Amount");
            }
        }
    }
}
