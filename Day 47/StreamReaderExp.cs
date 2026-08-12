using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1.Day_47
{
    internal class StreamReaderExp
    {
        public static void Main70(string[] args)
        {
            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Day 47", "example.txt");


            using (StreamReader sr = new StreamReader(filePath)) { 
                string content = sr.ReadToEnd();
                Console.WriteLine(content);
            }

            // line by line 
            FileStream fs = new FileStream(filePath, FileMode.Open);
            using (StreamReader sw = new StreamReader(fs)) {
                //string line;
                //while ((line = sw.ReadLine())!=null)
                //{
                //    Console.WriteLine(line);
                //}
                int ch;
                    while ((ch = sw.Read()) != -1) { 
                        Console.WriteLine(ch);
                    }
            }  

        }
    }
}
