using Solid_EmployeeManagmentSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_EmployeeManagmentSystem.Entities
{
    internal class Intern : Employee, IWorkable
    {
        public int DurationInMonths { get; set; }
        public override double CalculateSalary() => 30000;

        public void Work() => Console.WriteLine($"{Name} is working as an intern since {DurationInMonths} months");
    }
}
