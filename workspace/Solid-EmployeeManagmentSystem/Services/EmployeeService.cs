using Solid_EmployeeManagmentSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_EmployeeManagmentSystem.Services
{
    internal class EmployeeService
    {
        public double CalculateTotalMonthlyPayment(List<Employee> employees) {
            double total = 0;

            foreach (var e in employees) {
                total += e.CalculateSalary();
            }

            return total;
        }

        public void GetAllEmployees(List<Employee> employees) {
            foreach (var e in employees) 
            {
                Console.WriteLine($"{e.Name} earns {e.CalculateSalary()} per month");
            }
        }
    }
}
