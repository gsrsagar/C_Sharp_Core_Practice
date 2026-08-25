using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day52
{
     class Student1
    {
        public string Name { get; set; }

        public Student1(string Name)
        {
            Console.WriteLine("Base class Cons");
            this.Name = Name;
        }

        public void Display()
        {
            Console.WriteLine("Display age Base class ");
        }
    }

    class CSEClass : Student1
    {
        public CSEClass(string name) : base(name)
        {
            Console.WriteLine("Child Class Cons");
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("Display age Base class Child ");
        }
        public static  void Mai22n(string[] args)
        {
            Student1 o = new Student1("Sagar");
            CSEClass o1 = new CSEClass("Stack");
            o1.Display();

        }
    }
}
