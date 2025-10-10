using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Solid_EmployeeManagmentSystem.Controllers;
using Solid_EmployeeManagmentSystem.Interfaces;
using Solid_EmployeeManagmentSystem.IoC;
using Solid_EmployeeManagmentSystem.Services;

public class Program {

    //static void Main() {
    //    INotificationService notification = new EmailNotification();
    //    IReportService report = new ReportService();
    //    IEmployeeService service = new EmployeeService(report, notification);
    //    var controller = new EmployeeController(service);

    //    controller.Run();
    //}

    static async Task Main(string[] args) {
        using IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    //register the services
                    services.AddEmployeeManagement();

                    services.AddLogging(builder => builder.AddConsole());
                })
                .Build();

        using (var scope = host.Services.CreateScope()) {
            var provider = scope.ServiceProvider;

            var controller = provider.GetRequiredService<EmployeeController>();

            controller.Run();
        }

        await host.StopAsync();
    }
}