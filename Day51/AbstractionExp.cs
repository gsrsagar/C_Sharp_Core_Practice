using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day51
{
    internal class AbstractionExp
    {
        public static void Maisssn(string [] args)
        {
            Student1 o = new Impl("Sagar");
            o.displayStudentInfo();
        }
    }

    abstract class Student1
    {

        public Student1(string name)
        {
            this.name = name;

        }
        public string name {  get; set; }

        public void walk()
        {
            Console.WriteLine("I am walking");
        }
        public abstract void displayStudentInfo();
    }

    class Impl : Student1 {

        public Impl(string name) : base(name)
        {

        }
        public override void displayStudentInfo()
        {
            Console.WriteLine(this.name+"This is displayed");
        }
    }

}
