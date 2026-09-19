using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day_53
{
    class Overloading
    {
        public static int AddNums(int a , int b)
        {
            //
            //
            //
            Console.WriteLine("Called a,b");
            return a + b ;
        }

        public static int AddNums(int a, int b, int c )
        {
            //
            //
            //
            Console.WriteLine("Called a,b,c");
            return a + b+c;
        }

        public static float AddNums(float a, float b)
        {
            Console.WriteLine("Called float a,b");
      
            // float - 8 bytes , int - 4 bytes 
            return a + b;

        }

        // overloading 
        // means a class having same Method multiple times with diff erent parameters
        public static void Main233(string [] args)
        {

            Console.WriteLine(1);
         

           var result1 =  Overloading.AddNums(1, 2);
           var result2 = Overloading.AddNums(1, 2,3);
           var result3 = Overloading.AddNums(1.0f, 2.0f);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }
    }
}
