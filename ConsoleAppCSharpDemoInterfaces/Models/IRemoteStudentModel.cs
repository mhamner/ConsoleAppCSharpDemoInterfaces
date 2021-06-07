using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharpDemoInterfaces.Models
{
    interface IRemoteStudentModel: IStudentModel
    {
        void ShipShirt();
    }
}
