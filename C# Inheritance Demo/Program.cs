using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region PersonClass
            ////Default constructor
            //Person p = new Person();
            //p.SetData();
            //p.GetData();

            ////Parameterized constructor
            //Person p1 = new Person(100, "XYZ", 100, "12345");
            //p1.GetData();

            ////Copy Constructor
            //Person p2 = new Person(p1);
            //p2.GetData();
            #endregion

            //Student Class
            //Student s1 = new Student();
            //s1.SetStudentData();
            //s1.GetStudentData();
            //s1.GetData();

            //Student s2 = new Student();
            //s2.GetStudentData();
            //s2.GetData();

            //Student s3 = new Student(100, "XYZ", 100, "From Person Class", 1, 1, "From Student class", 100);
            //s3.GetStudentData();
            //s3.GetData();

            Student s4 = new Student(100, "XYZ", 100, "From Person Class", 1, 1, "From Student class", 100);
            s4.GetData();
            s4.DisplayHello();

            Console.ReadKey();

        }
    }
}
