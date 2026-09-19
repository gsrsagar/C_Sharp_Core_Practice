using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day_53
{
    class ClassCasting
    {
        public static void Main2343(string[] args)
        {
            Mammal mom = new Mammal();
            Human son = new Human();

            Mammal m = new Human();
            m.Display();
          //  m = mom; // Upcasting
            m.Display();

        }
    }


    class Mammal
    {
        public virtual void Display()
        {
            Console.WriteLine("I am Mammal");
        }
    }

    class  Human : Mammal
    {
        public override void Display()
        {
            Console.WriteLine("I am Human");
        }
    }
}
