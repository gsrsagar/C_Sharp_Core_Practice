using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day55
{
    internal class TryCatchFinally
    {
        public static void Main323(string[] args)
        {
            string path = "../example.txt";
            FileStream fs = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                int content = fs.ReadByte();
                Console.WriteLine(content);
            }catch(IndexOutOfRangeException e)
            {
                
                Console.WriteLine(e.StackTrace);
            } catch(Exception e)
            {
                Console.WriteLine("Cannot find the file which you are trying to accesss, please contact admin");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            } finally
            {
                //fs.Close();
                Console.WriteLine("File stream closed");
                Console.WriteLine("Exception Chain is Completed");
            }

        }
    }
}
