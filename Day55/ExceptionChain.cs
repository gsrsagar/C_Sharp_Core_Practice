using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day55
{
    internal class Exception_Chain
    {
        public void ReadFile1()
        {

            string path = "../example.txt";
            FileStream fs = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                int content = fs.ReadByte();
                Console.WriteLine(content);
            }
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine(e.StackTrace);
            }
            catch (Exception e)
            {
                throw new SenakFileNotFoundExcpetion("Cannot find the file which you are trying to accesss, please contact admin");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                //fs.Close();
                Console.WriteLine("File stream closed");
                Console.WriteLine("Exception Chain is Completed");
            }
        }

        public static void Main(string[] args)
        {
            Exception_Chain o = new Exception_Chain();
            try
            {
                o.ReadFile1();

            }
            catch (SenakFileNotFoundExcpetion e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                o.ReadFile1();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
