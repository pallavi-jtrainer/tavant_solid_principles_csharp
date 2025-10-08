
using SRP_Demo.entities;
using SRP_Demo.repository;
using SRP_Demo.services;

class Program {

    static void Main() {
        var products = new List<Product>()
        {
            new Product { Name = "Laptop", Category="Electronics", Price = 2300},
            new Product { Name = "Book", Category = "Stationary", Price = 2500}
        };

        var order = new Order
        {
            products = products,
            customerEmail = "customer@example.com",
            PaymentType = "DebitCard",
            Quantity = 2
        };

        //create services
        var calculator = new OrderCalculator();
        var repo = new OrderRepository();
        var email = new EmailService();
        var validator = new OrderValidator();
        var service = new OrderService(validator, email, repo, calculator);

        service.ProcessOrder(order);

        Console.WriteLine("--All Orders--");
        foreach (var o in repo.GetOrders()) { 
            Console.WriteLine($"Order #{o.Id}: {o.total:C}");
        }

    }
}