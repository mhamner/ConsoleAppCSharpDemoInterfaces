using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppCSharpDemoInterfaces.Models;

namespace ConsoleAppCSharpDemoInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create some test data
            List <IStudentModel> students = CreateSomeStudents();
            //List<OnCampusStudentModel> students = CreateSomeStudents();
            
            foreach(IStudentModel student in students)
            {
                student.SendEmail();
                if(student is IRemoteStudentModel remoteStudent)
                {
                    Console.WriteLine($"{remoteStudent.StudentName} is a remote learner.");
                }
            }

            Console.ReadKey();
        }

        private static List<IStudentModel> CreateSomeStudents()
        {
            List<IStudentModel> studentList = new List<IStudentModel>();
            //List<OnCampusStudentModel> studentList = new List<OnCampusStudentModel>();
            
            //Create and add some on campus students
            OnCampusStudentModel student1 = new OnCampusStudentModel("Harry Potter", "Cupboard under the stairs", "harry@hogwarts.edu", "19", "1901");
            studentList.Add(student1);
            OnCampusStudentModel student2 = new OnCampusStudentModel("Hermione Granger", "201 First Street", "hermione@hogwarts.edu", "19", "1901");
            studentList.Add(student2);
            OnCampusStudentModel student3 = new OnCampusStudentModel("Ron Weasley", "789 Big Field", "ron@hogwarts.edu", "19", "1901");
            studentList.Add(student3);

            //Create and add some remote students
            RemoteStudentModel rstudent1 = new RemoteStudentModel("Neville Longbottom", "123 Narrows", "neville@hogwarts.edu");
            studentList.Add(rstudent1);
            RemoteStudentModel rstudent2 = new RemoteStudentModel("Luna Lovegood", "That big weird house", "luna@hogwarts.edu");
            studentList.Add(rstudent2);

            return studentList;
        }
    }
}
