using Solid_EmployeeManagmentSystem.Entities;
using Solid_EmployeeManagmentSystem.Interfaces;
using Solid_EmployeeManagmentSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_EmployeeManagmentSystem.Controllers
{
    internal class EmployeeController
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService) {
            _employeeService = employeeService;
        }

        public void Run() {
            var employees = new List<Employee> {
                new Developer { Id = 1, Name = "Alice", Email="alice@xyz.com", LinesOfCodePerDay=120},
                new Developer { Id = 2, Name = "John", Email="john@xyz.com", LinesOfCodePerDay=150},
                new Developer { Id = 3, Name = "Max", Email="max@xyz.com", LinesOfCodePerDay=95},

                new Manager { Id = 10, Name="Charlie", Email="charlie@xyz.com", TeamSize=5},

                new Intern { Id = 23, Name="Robert", Email="robert@xyz.com", DurationInMonths=3}
            };

            Console.WriteLine("Employee Details");
            _employeeService.GetAllEmployees(employees);

            Console.WriteLine("Activities");

            foreach (var e in employees) {
                if (e is IWorkable w) w.Work();
                if (e is IMeetingAttendee m) m.AttendMeeting();
                if (e is IManageable mg) mg.ManageTeam();
                if (e is IInterviewable i) i.ConductInterview();
            }

        }
    }
}
