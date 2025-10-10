using Solid_EmployeeManagmentSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_EmployeeManagmentSystem.Services
{
    internal class EmailNotification : INotificationService
    {
        public void Notify(string message) { 
            Console.WriteLine($" [Email Notification]: {message}");
        }
    }
}
