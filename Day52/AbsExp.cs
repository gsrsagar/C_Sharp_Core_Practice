using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Day_53;

namespace ConsoleApp1.Day52
{
    abstract class AbsExp
    {
        public abstract void Display();
    }


    class Exp : AbsExp
    {
        public override void Display()
        {
            Console.WriteLine("IMplemented");
        }
        public static void Main12(string[] args)
        {
            Exp exp = new Exp();
            exp.Display();
            Human2 o = new Human2();
        }
    }
}
