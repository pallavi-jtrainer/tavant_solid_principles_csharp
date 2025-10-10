using Solid_EmployeeManagmentSystem.Entities;
using Solid_EmployeeManagmentSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_EmployeeManagmentSystem.Services
{
    internal class EmployeeService :IEmployeeService
    {
        private readonly IReportService _reportService;
        private readonly INotificationService _notificationService;

        public EmployeeService(IReportService reportService, INotificationService notificationService)
        {
            _reportService = reportService;
            _notificationService = notificationService;
        }

        public double CalculateTotalMonthlyPayment(List<Employee> employees) {
            double total = 0;

            foreach (var e in employees) {
                total += e.CalculateSalary();
                _notificationService.Notify($"{e.Name}'s salary has been processed");
            }

            return total;
        }

        public void CreateEmployee(Employee employee)
        {
            Console.WriteLine($"Employee: {employee.Name} saved into the Database");
        }

        public void GetAllEmployees(List<Employee> employees) {
            //foreach (var e in employees) 
            //{
            //    Console.WriteLine($"{e.Name} earns {e.CalculateSalary()} per month");
            //}
            _reportService.GenerateEmployeeReport(employees);
        }

        public void PrintWorkReport(List<Employee> employees) {
            Console.WriteLine("Employee Work Report: ");

            foreach (var e in employees) {
                if (e is IWorkable w) {
                    Console.Write($"{e.Name} -> ");
                    w.Work();
                }
                else
                {
                    Console.WriteLine($"{e.Name} does not perform any special tasks");
                }
            }
        }
    }
}
