using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharpDemoInterfaces.Models
{
    public class OnCampusStudentModel : IStudentModel
    {
        public OnCampusStudentModel(string studentName, string studentAddress, string studentEmailAddress, string homeroomRoomNumber, string homeroomFloor)
        {
            StudentName = studentName;
            StudentAddress = studentAddress;
            StudentEmailAddress = studentEmailAddress;
            HomeroomRoomNumber = homeroomRoomNumber;
            HomeroomFloor = homeroomFloor;
        }

        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public string StudentEmailAddress { get; set; }
        public string HomeroomRoomNumber { get; set; }
        public string HomeroomFloor { get; set; }

        public void SendEmail()
        {
            Console.WriteLine($"Email sent to {StudentName}.");
        }

    }
}
