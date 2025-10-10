using Solid_EmployeeManagmentSystem.Entities;
using Solid_EmployeeManagmentSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_EmployeeManagmentSystem.Services
{
    internal class ReportService : IReportService
    {
        public void GenerateEmployeeReport(List<Employee> employees) {
            Console.WriteLine("Employee Report");

            foreach (var e in employees) {
                Console.WriteLine($"{e.Name} earns {e.CalculateSalary} per month");
            }
        }
    }
}
