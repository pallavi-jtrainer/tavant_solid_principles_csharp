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
        public double CalculateTotalMonthlyPayment(List<Employee> employees) {
            double total = 0;

            foreach (var e in employees) {
                total += e.CalculateSalary();
            }

            return total;
        }

        public void CreateEmployee(Employee employee)
        {
            Console.WriteLine($"Employee: {employee.Name} saved into the Database");
        }

        public void GetAllEmployees(List<Employee> employees) {
            foreach (var e in employees) 
            {
                Console.WriteLine($"{e.Name} earns {e.CalculateSalary()} per month");
            }
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
