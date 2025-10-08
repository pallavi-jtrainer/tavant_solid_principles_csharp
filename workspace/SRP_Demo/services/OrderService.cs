using SRP_Demo.entities;
using SRP_Demo.repository;
using SRP_Demo.services.discount;
using SRP_Demo.services.payment;
using SRP_Demo.services.shipping;
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
            double discountAmt = 0;

            foreach (var p in order.products) {
                var cat = DiscountFactory.GetDiscountStrategy(p.Category);

                double discount = cat.ApplyDiscount(p);

                discountAmt += discount;

            }

            double sum = _orderCalculator.CalculateOrderTotal(order);
            order.total = sum - discountAmt;

            var shippingStrategy = ShippingFactory.GetShippingStrategy("Standard");

            double shippingCost = shippingStrategy.CalculateShippingCost(order);

            order.total += shippingCost;
            
            _validator.Validate(order);
            
            _emailService.SendEmail(order.customerEmail, $"Order #{order.Id} Confirmed. Total Amount: {order.total}");

            var paymentStrategy = PaymentFactory.GetPaymentStrategy(order.PaymentType);
            paymentStrategy.Pay(order.total);

            _orderRepository.Save(order);

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
