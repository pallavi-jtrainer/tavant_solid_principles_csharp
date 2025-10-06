using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo.services
{
    internal class EmailService
    {
        public void SendEmail(string to, string message) {
            Console.WriteLine($"Email sent to {to}: {message}");
        }
    }
}
