using System;
using System.Collections.Generic;
using System.Text;

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
        public static void Main(string[] args)
        {
            Exp exp = new Exp();
            exp.Display();
        }
    }
}
