using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day_47
{
    internal class FileDeleteExp
    {
        public static void Main76(string[] args)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                "Day 47", "example2.txt");

                File.Delete(filePath);
            Console.WriteLine("Delete Was Done");


            using (StreamReader sr = new StreamReader(filePath))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine(content);
            }

        }
    }
}
