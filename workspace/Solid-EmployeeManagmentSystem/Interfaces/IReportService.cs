using Solid_EmployeeManagmentSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_EmployeeManagmentSystem.Interfaces
{
    internal interface IReportService
    {
        void GenerateEmployeeReport(List<Employee> employees);
    }
}
