using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1.Day_47
{
    internal class StreamWriterExp
    {
        public static void Main72(string[] args)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                "Day 47", "example.txt");
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Line number 5 this is fifth line form the exmaple.txt");
                sw.WriteLine("Line number 6 this is fifth line form the exmaple.txt");
                //sw.Flush();

            }

            using (StreamReader sr = new StreamReader(filePath))
            {
                Console.WriteLine("Reading New IMplemented lines");
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
