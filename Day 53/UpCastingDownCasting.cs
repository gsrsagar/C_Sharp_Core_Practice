using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day_53
{
     class UpCastingDownCasting
    {
        public static void Main122(string[] args)
        {
            Mammal1 m1 = new Human1();

            Human1 h = new Human1();
            h = (Human1)m1; // upcasting to downcasting

            m1.Display();
            h.Display();
        }
    }

    class Mammal1
    {
        public virtual void Display()
        {
            Console.WriteLine("I am Mammal");
        }
    }

    class Human1 : Mammal1  
    {
        public override void Display()
        {
            Console.WriteLine("I am Human");
        }
    }
   
}
