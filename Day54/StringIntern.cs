using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day53
{
    internal class StringIntern
    {
        public static void Main22(string[] args)
        {
            string s = "Hello";
            string s1 = "Hello";
            Console.WriteLine(object.ReferenceEquals(s, s1)); 

        }
    }
}
