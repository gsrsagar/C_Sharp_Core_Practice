using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class ClassesAndObjects
    {
        public static void Main6(string[] args)
        {
            Student s  = new Student(); //declare
            // creating a new Mmeory allocation  instantiation ,  intilaization

          //  Student s1 = new Student("Sagar",10,"Pune",101);
          //  Student s2 = new Student(s1, 102);
            s.age = 30;
            s.name = "Test";
            s.age = 20;
            Console.WriteLine(s.age);
            Console.WriteLine(s.name);
           // Console.WriteLine(s1.age);
            Console.WriteLine(new Student("Sagar", 10, "Pune", 101).address);
           // Console.WriteLine(s1.name);
          //  Console.WriteLine(s2.name);
          //  Console.WriteLine(s2.rollNo);
          //  Console.WriteLine(s2.address);
          //       Console.WriteLine(s1.GetHashCode());
        }
    }
}
