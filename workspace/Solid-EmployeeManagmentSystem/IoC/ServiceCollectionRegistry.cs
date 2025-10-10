using Microsoft.Extensions.DependencyInjection;
using Solid_EmployeeManagmentSystem.Controllers;
using Solid_EmployeeManagmentSystem.Interfaces;
using Solid_EmployeeManagmentSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_EmployeeManagmentSystem.IoC
{
    internal static class ServiceCollectionRegistry
    {
        public static IServiceCollection AddEmployeeManagement(this IServiceCollection services) {

            //stateless, thread-safe, single instance for the lifetime of the container
            services.AddSingleton<INotificationService, EmailNotification>();
            services.AddSingleton<IReportService, ReportService>();

            services.AddScoped<IEmployeeService, EmployeeService>();

            services.AddTransient<EmployeeController>();

            return services;
        }
        
    }
}
