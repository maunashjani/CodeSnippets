using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Person
    {
        int AadharID;
        string name;
        int age;
        string phoneno;

        public Person()
        {
            age = 22;
        }

        public Person(int AadharID, string name, int age, string phoneno)
        {
            this.AadharID = AadharID;
            this.name = name;
            this.age = age;
            this.phoneno = phoneno;

        }


        public Person(Person pObj)
        {
            this.AadharID = pObj.AadharID;
            this.name = pObj.name;
            this.age = pObj.age;
            this.phoneno = pObj.phoneno;
        }

        public void SetData()
        {
            AadharID = 12345;
            name = "Ramesh";
            age = 20;
            phoneno = "1234567890";
        }

        public void GetData()
        {
            Console.WriteLine("Aadhar ID:" + AadharID);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Phone No:" + phoneno);
        }

        public virtual void DisplayHello()
        {
            Console.WriteLine("Hello From Person Class");
        }
    }
}
