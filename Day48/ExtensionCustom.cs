using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day48
{
    static class ExtensionCustom
    {
        public static string ToUpperCustom(this string str)
        {
            return str.ToUpper();
        }

        public static int Add(this int a, int b , int c)
        {
            return a + b+c;
        }
    }
}
