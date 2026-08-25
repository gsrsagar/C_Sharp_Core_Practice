using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day51
{
    interface InterfaceExp
    {
        public int displayBalance();
    }

    interface Mammal1 {
        public void walk();

    }

    interface Reptile { // 100 Perc Abst
        public void swim();
        public void fly();
        public void walk();
    }

    class Humanas : Mammal1, Reptile {
    
        public void fly()
        {
            Console.WriteLine("Iam Flying");
        }

        public void walk()
        {
            Console.WriteLine("Iam walking");
        }

        public void swim()
        {
            Console.WriteLine("Iam swimmming");

        }
        public static void Main122(string[] args)
        {
            Mammal1 o = new Humanas();
            o.walk();
        }

    }



}
