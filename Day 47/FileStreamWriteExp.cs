using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day_47
{
    internal class FileStreamWriteExp
    {
        public static void Main72(string[] args)
        {
            string filePath = Path.Combine(
               AppDomain.CurrentDomain.BaseDirectory,
               "Day 47", "example.txt");

            using(FileStream fs  = new FileStream(filePath, FileMode.Create))
            {
                byte [] data= { 124, 23, 55, 33, 4, 120 };
                fs.Write(data, 0, data.Length);
                fs.Close();
            }

            using(StreamReader fs = new StreamReader(filePath))
            {
                string context = fs.ReadToEnd();
                Console.WriteLine(context);
            }
        }
    }
}
