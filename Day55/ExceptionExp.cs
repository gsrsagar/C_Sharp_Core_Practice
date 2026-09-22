using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day55
{
    internal class ExceptionExp
    {
        public static void Mai1n(string [] args)
        {
            int num = 0;
            int? result = null;
            try
            {
                result = 10 / num;
            } catch(ArgumentNullException e)
            {
                Console.WriteLine("Exception caught: " + e.Message);
                Console.WriteLine("Exception caught: " + e.StackTrace);
            } catch(IndexOutOfRangeException e)
            {

            }
            catch(Exception e)
            {
                Console.WriteLine("Exception caught: " + e.Message);
                Console.WriteLine("Exception caught: " + e.StackTrace);

            }
            
                Console.WriteLine("Result"+ (result.HasValue ? result.Value.ToString() : "No value"));
            Console.WriteLine("End of program");
        }
    }
}
