using Solid_EmployeeManagmentSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_EmployeeManagmentSystem.Entities
{
    internal class HR : Employee, IInterviewable, IMeetingAttendee
    {
        public override void Activities()
        {
            ConductInterview();
            AttendMeeting();
        }

        public override double CalculateSalary()
        {
            return 75000;
        }

        public void ConductInterview() => Console.WriteLine($"{Name} conducts Interviews");
        public void AttendMeeting() => Console.WriteLine($"{Name} is attending a HR meeting");
    }
}
