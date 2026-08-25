using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day52
{
    static class StaticClassExp
    {

        public static int age = 20;

        public static string ToUpperAndLower(this string str)
        {
            return str.ToUpper()+" "+str.ToLower();
        }
    }

    class Impl1
    {
        public static void Main21223(string[] args)
        {
            Impl1 i = new Impl1();
            Console.WriteLine(StaticClassExp.age);

            string courseName = "Dotnet";
            courseName = courseName.ToUpper();

            int [] nums = { 1, 2, 3, 4, 5 };
            nums.Where(x => x % 2 == 0).ToList();

            string name = "Sagar";
            name = name.ToUpperAndLower(); // extension Method customized
            Console.WriteLine(name);
        }
    }
}
