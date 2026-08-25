using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day51
{
    internal class InheritanceExp
    {
        public static void Main223(string[] args)
        {
            Mammal h = new HumanBeing("Pandu");
           // h.name; // it will not work
            h.walk();
        }
    }


    class Mammal
    {
        protected string name { get; set; }

        public Mammal(string input)
        {
            name = input;
        }

        public void walk()
        {
            Console.WriteLine(name + "is walking");
        }
    }

    class Human : Mammal
    {
        public Human(string name) : base(name)
        {
            Console.WriteLine("Constructor caleld");

        }
    }

    // Multi level

    class HumanBeing : Human
    {
        public HumanBeing(string name) : base(name)
        {
            Console.WriteLine("Constructor caleld");

        }

    }


}
