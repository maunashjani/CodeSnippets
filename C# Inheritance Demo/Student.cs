using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Student : Person
    {
        int collegeID;
        int RollNo;
        string classname;
        int marks;

        public Student() : base()
        {
            collegeID = 1000;
            RollNo = 101;
            classname = "Second Yr";
            marks = 80;
        }

        public Student(int AadharID, string name, int age, string phoneno, int collegeID, int RollNo, string classname, int marks) : base(AadharID, name, age, phoneno)
        {
            this.collegeID = collegeID;
            this.RollNo = RollNo;
            this.classname = classname;
            this.marks = marks;
        }

        //public void GetStudentData()
        //{
        //    Console.WriteLine("College ID: " + this.collegeID);
        //    Console.WriteLine("Roll No: " + this.RollNo);
        //    Console.WriteLine("Class Name: " + this.classname);
        //    Console.WriteLine("Marks: " + this.marks);
        //}

        public new void GetData()
        {
            base.GetData();
            Console.WriteLine("College ID: " + this.collegeID);
            Console.WriteLine("Roll No: " + this.RollNo);
            Console.WriteLine("Class Name: " + this.classname);
            Console.WriteLine("Marks: " + this.marks);
        }

        public void SetStudentData()
        {
            this.collegeID = 101;
            this.RollNo = 1;
            this.classname = "SY CS";
            this.marks = 70;
        }

        public override void DisplayHello()
        {
            base.DisplayHello();
            Console.WriteLine("Hello From Student Class");
        }

    }
}
