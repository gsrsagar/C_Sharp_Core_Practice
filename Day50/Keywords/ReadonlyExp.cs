using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day50.Keywords
{
    internal class ReadonlyExp
    {
        protected readonly int a;

        public ReadonlyExp(int input)
        {
            this.a = input;
        }


        public static void Main122(string[] args)
        {
            ReadonlyExp o = new ReadonlyExp(5);
          //  o.a = 6;
            Console.WriteLine(o.a);
        }
    }
}
