using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1.Day49
{
    internal class StringsOps
    {
        public static void Main123(string[] args)
        {
            string name = "Sagar"; // 
            Console.WriteLine(name);
            name = "SUnil";
            Console.WriteLine(name);

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Day 47","example.txt");


            using (StreamReader sr = new StreamReader(filePath))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine(content);
            }


        }
    }
}
