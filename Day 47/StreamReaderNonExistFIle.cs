using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1.Day_47
{
    internal class StreamReaderNonExistFIle
    {
        public static void Main72(string[] args)
        {
            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Day 47", 
                "exampe.txt");

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            } catch(Exception e)
            {
                Console.WriteLine("Printing"+e.Message);
            }
            

            Console.WriteLine("Operation done");
        }
    }
}
