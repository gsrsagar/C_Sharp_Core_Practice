using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day_47
{
    internal class ConsoleOps
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter string line");
            string text = Console.ReadLine();
            

            Console.WriteLine("enter int");
            Int32 age = Convert.ToInt32(Console.Read());
            Console.WriteLine("enter float");
            float marks = (float)Convert.ToDecimal(Console.Read());


            Console.WriteLine(text);
            Console.WriteLine(marks);
            Console.WriteLine(age);

        }
    }
}
