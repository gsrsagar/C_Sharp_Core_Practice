using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day_53
{
     class MethodHiding
    {
        public static void Main223(string[] args)
        {
            Human2 o = new Human2();
            o.Display();
        }
    }

    class Mamal2
    {
        public void Display()
        {
            Console.WriteLine("I am Mammal");
        }
    }

    class Human2 : Mamal2
    {
        public new void Display()
        {
            Console.WriteLine("I am Human");
        }
    }
}
