using Solid_EmployeeManagmentSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_EmployeeManagmentSystem.Entities
{
    internal class Developer : Employee, IMeetingAttendee, IWorkable
    {
        public int LinesOfCodePerDay { get; set; }
        public override double CalculateSalary() => 60000;

        public void Work() => Console.WriteLine($"{Name} writes {LinesOfCodePerDay} lines of code everyday");
        public void AttendMeeting() => Console.WriteLine($"{Name} is attending a Standup Meeting");

        public override void Activities()
        {
            Work();
            AttendMeeting();
        }
    }
}
