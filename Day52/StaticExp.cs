using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day52
{
    class StaticExp
    {
        // Static Fields 
        public static int age = 20;

        static StaticExp()
        {
            Console.WriteLine("Loaded Static Constructor");
            age = 30;age++; ++age;
        }
        // Static method 
        public static int add(int a , int b)
        {
            return a + b;
        }
        public StaticExp(){
            Console.WriteLine("Defsult Cons");
        }


        public static void Main212(string[] args)
        {
            Console.WriteLine(age);
            Console.WriteLine(add(1, 2));
        }

    }

    class Impl
    {
        public static void Main1222(string[] args)
        {
            StaticExp p = new StaticExp();
            Console.WriteLine(StaticExp.age);
            Console.WriteLine(StaticExp.add(1,2));
        }
    }
}
