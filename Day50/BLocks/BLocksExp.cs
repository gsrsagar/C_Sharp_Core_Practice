using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day50.BLocks
{
    internal class BLocksExp
    {
        public static string name { get; set; }
        static BLocksExp()
        {
            Console.WriteLine("Static Constructor");
            name = "Sagar";

        }
        public int balance { get; set; } // instance variables

        public void PrintName(string name)
        {
            Console.WriteLine(name); // local , method
        }

        public static void PrintName1(string name)
        {
            Console.WriteLine(name); // static local block
        }

        public static void Main122(string[] args)
        {
            BLocksExp o = new BLocksExp();
            Console.WriteLine(o.balance);
            o.PrintName("Sagar"); // 
            PrintName1("Sunil");
        }
    }
}
