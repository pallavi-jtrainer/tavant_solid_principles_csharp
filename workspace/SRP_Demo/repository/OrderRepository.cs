using SRP_Demo.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo.repository
{

    internal class OrderRepository
    {
        private readonly List<Order> _orders = new List<Order>();

        public void Save(Order order) {
            order.Id = _orders.Count + 1;
            _orders.Add(order);
            Console.WriteLine($"Order # {order.Id} saved successfully. Total number of products in this order: {order.products.Count}");
        }

        public IEnumerable<Order> GetOrders() => _orders;

        public Order GetOrder(int id) => _orders[id];
    }
}
