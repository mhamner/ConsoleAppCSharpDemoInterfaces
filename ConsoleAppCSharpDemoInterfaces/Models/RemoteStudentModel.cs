using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharpDemoInterfaces.Models
{
    public class RemoteStudentModel : IRemoteStudentModel
    {
        public RemoteStudentModel(string studentName, string studentAddress, string studentEmailAddress)
        {
            StudentName = studentName;
            StudentAddress = studentAddress;
            StudentEmailAddress = studentEmailAddress;
        }
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public string StudentEmailAddress { get; set; }

        public void SendEmail()
        {
            Console.WriteLine($"Email sent to {StudentName}.");
        }

        //This is a method in the remote student model that the on campus one doesn't have / need because they get their t-shirts in homeroom
        //This shows how you can add extra methods to a class that implements an interface
        public void ShipShirt()
        {
            Console.WriteLine($"T-Shirt shipped to {StudentName} at {StudentAddress}.");
        }
    }
}
