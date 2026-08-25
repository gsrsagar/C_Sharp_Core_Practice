using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Day51;

namespace ConsoleApp1.Day50
{
    internal class ProtectedImpl : ProtectedExp
    {
        public static void Main122(string[] args)
        {
            ProtectedImpl o = new ProtectedImpl();
            o.age = 1;
            Console.WriteLine(o.age);

        }
    }
}
