using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day48
{
    internal class CallByValueAndReference
    {
       

        public static void AddByRef(int a, int b, ref int result)
        {
            result = a + b;
        }

        public static void AddByRefOut(int a, int b, out int result)
        {
            result = a + b;
        }
        public static void Main234(string[] args)
        {
         
            int result2 = 0; // ref is used to do call by value by declaring and initializing it
            AddByRef(2, 4, ref result2);
            Console.WriteLine(result2);

            AddByRefOut(3, 4, out int result3);
            Console.WriteLine(result3);
        }
    }
}
