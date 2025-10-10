using Solid_EmployeeManagmentSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_EmployeeManagmentSystem.Interfaces
{
    internal interface IEmployeeService
    {
        double CalculateTotalMonthlyPayment(List<Employee> employees);
        void GetAllEmployees(List<Employee> employees);

        void CreateEmployee(Employee employee);

        void PrintWorkReport(List<Employee> employees);
    }
}
