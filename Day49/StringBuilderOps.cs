using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day49
{
    internal class StringBuilderOps
    {
        public static void Main123(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hi this is Sagar");
            sb.Append("Hello Mansi");

            sb = new StringBuilder(); // new object
            sb.Append(" Hi this is fresh");
            //        15 - 14

            Console.WriteLine(sb.ToString());

            // find length 
            int length = sb.Length;
            Console.WriteLine(length);

            int index = sb.ToString().IndexOf("f");
            Console.WriteLine(index);

            string subs = sb.ToString().Substring(6, 9);
            Console.WriteLine(subs);

            string output = sb.ToString().Replace("fresh", "Candy");
            Console.WriteLine(output);
        }
    }
}
