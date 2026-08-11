using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ConsoleApp1.Day_47
{
    internal class FileCopyExp
    {
        public static void Main75(string[] args)
        {
            string filePath1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                "Day 47", "example.txt");

                string filePath2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                "Day 47", "example2.txt");

            File.Copy(filePath1, filePath2, true);
            Console.WriteLine("Operation Copy Done");


            using (StreamReader sr = new StreamReader(filePath2))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine(content);
            }
        }
    }
}
