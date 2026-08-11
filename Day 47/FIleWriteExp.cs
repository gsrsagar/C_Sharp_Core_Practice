using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1.Day_47
{
    internal class FIleWriteExp
    {
        public static void Main74(string[] args)
        {
            string filePath = Path.Combine(
              AppDomain.CurrentDomain.BaseDirectory,
              "Day 47", "example.txt");

            using (FileStream fs = File.Create(filePath))
            {
                byte[] data = { 123, 56, 34, 77, 33, 67, 120 };
                fs.Write(data, 0, data.Length);
                fs.Flush();
            }

            using (StreamReader sr = new StreamReader(filePath))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine(content);
            }

        }
    }
}
