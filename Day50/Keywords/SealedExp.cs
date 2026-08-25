using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day50.Keywords
{
     public sealed class SealedExp
    {
        public SealedExp() { }

        public int balance { get ; set; }
    }

    public class IMpl
    {
        public IMpl() { }

        public static void Main122(string[] args)
        {

            SealedExp o = new SealedExp();
            Console.Write(o.balance);
        }
    }
}
