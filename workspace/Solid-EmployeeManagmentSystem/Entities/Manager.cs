using Solid_EmployeeManagmentSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_EmployeeManagmentSystem.Entities
{
    internal class Manager : Employee, IInterviewable, IManageable, IMeetingAttendee
    {
        public int TeamSize { get; set; }
        public override double CalculateSalary()
        {
            return 120000;
        }

        //public void Work() => Console.WriteLine($"{Name} is planning a spring meeting");
        public void AttendMeeting() => Console.WriteLine($"{Name} is attending a Management meeting");

        public void ManageTeam() => Console.WriteLine($"{Name} is managing a team of {TeamSize} members");

        public void ConductInterview() => Console.WriteLine($"{Name} is conducting an interview");

        public override void Activities()
        {
            //Work();
            AttendMeeting();
            ManageTeam();
            ConductInterview();
        }
    }
}
