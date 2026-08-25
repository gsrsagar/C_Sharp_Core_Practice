using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day52
{
    class Student
    {
        public static void Display()
        {
            Console.WriteLine("Iam Student");
        }
    }
    class HideStaticMethodExp : Student
    {

        public new static void Display()
        {
            Console.WriteLine("Iam Student New Static in Child Class");
        }
        public static void Main22(string[] args)
        {
            HideStaticMethodExp.Display();
        }
    }
}
