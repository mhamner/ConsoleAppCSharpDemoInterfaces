using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharpDemoInterfaces.Models
{
    public interface IStudentModel
    {
        string StudentName { get; set; }
        string StudentAddress { get; set; }
        string StudentEmailAddress { get; set; }

        void SendEmail();
    }
}
