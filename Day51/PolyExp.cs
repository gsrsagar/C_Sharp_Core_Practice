using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ConsoleApp1.Day51
{
    internal class PolyExp
    {
        // POly means 
        // Many methods with Same name and Different name also

        public static void Main122(string[] args)
        {
            PolyExp polyExp = new PolyExp();
            Console.WriteLine(polyExp.add(1, 2));
            Console.WriteLine(polyExp.add(1.6f, 2.0f));
            Console.WriteLine(polyExp.add(1, 2, 3)); //in the compulation its knows

            Console.WriteLine(1);
            Console.WriteLine("Sagar");
            Console.WriteLine(true);
            Console.WriteLine('c');
            
        }
        public int add(int a, int b)
        {
            return a + b;
        }

        public int add(int a, int b , int c)
        {
            return a + b + c;
        }

        public float add(float a, float b)
        {
            return a + b;
        }
    }
}
