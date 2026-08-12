using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day48
{
    internal class ExtensionMethodsExp
    {
        public static void Main3445(string[] args)
        {
            string s = "Sagar";
            s = s.ToUpperCustom();
            Console.WriteLine(s);
            int a = 5;
            int result = a.Add(6,7);
            Console.WriteLine(result);
        }
    }
}
