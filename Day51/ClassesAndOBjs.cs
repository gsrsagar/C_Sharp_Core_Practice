using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day51
{
    internal class ClassesAndOBjs
    {
        public int age { get; set; } = 123;
        public string name { get; set; } = "Sagar";

        public int add(int a, int b)
        {
            return a + b;
        }

        public static void Main23(string[] args)
        {
            ClassesAndOBjs o = new ClassesAndOBjs();
            Console.WriteLine(o.age);
            Console.WriteLine(o.name);

        }
    }
}
