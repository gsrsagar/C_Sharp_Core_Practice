using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student
    {
        public int age { get; set; } // 4 bytes 
        public string? name { get; set; } // non static  // null // 4 bytes
        public string? address { get; set; }
        public int rollNo { get; set; }

        /// Student s = new Student();
        /// s.name ="Test";
        /// 
        public Student()
        {
            Console.WriteLine("Default Constructor");
        }

        public Student(string _name, int _age, string address, int rollNo)
        {
            this.name = _name;
            age = _age;
            this.address = address;
            this.rollNo = rollNo;
        }

        public Student(Student obj, int rollNo)
        {
            this.name = obj.name;
            this.age = obj.age;
            this.address = obj.address;
            this.rollNo = rollNo;
        }
    }
}
