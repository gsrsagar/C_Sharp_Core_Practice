using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day51
{
    internal class RunTimePOly
    {
        public static void Main1223(string[] args)
        {
            A obj = new B();
            obj.display(); // run time poly
           // obj.display1();
        }
    }


    class A
    {
        public virtual void display()
        {
            Console.WriteLine("DIsplay from Class A");
        }


    }

    class B : A {
        public override void display()
        {
            Console.WriteLine("DIsplay from Class B");
        }

        public void display1()
        {
            Console.WriteLine("DIsplay1 from Class B");
        }
    }

}
