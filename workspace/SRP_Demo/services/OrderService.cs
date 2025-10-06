using SRP_Demo.entities;
using SRP_Demo.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo.services
{
    internal class OrderService
    {

        private readonly OrderValidator _validator;
        private readonly OrderRepository _orderRepository;
        private readonly EmailService _emailService;
        private readonly OrderCalculator _orderCalculator;

        public OrderService(OrderValidator orderValidator, EmailService emailService, 
            OrderRepository orderRepository, OrderCalculator orderCalculator) {
            _orderRepository = orderRepository;
            _validator = orderValidator;
            _emailService = emailService;
            _orderCalculator = orderCalculator;
        }

        public void ProcessOrder(Order order)
        {
            double sum = _orderCalculator.CalculateOrderTotal(order);
            order.total = sum;
            _validator.Validate(order);
            _orderRepository.Save(order);
            _emailService.SendEmail(order.customerEmail, $"Order #{order.Id} Confirmed");

            //if (order.total <= 0)
            //{
            //    throw new Exception("Invalid order amount");
            //}

            //var repo = new OrderRepository();
            //repo.Save(order);

            //var eamilService = new EmailService();
            //eamilService.Send(order.customerEmail, "Order placed and confirmed");
        }


    }
}
