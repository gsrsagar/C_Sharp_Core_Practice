using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day53
{
    internal class OptionalValuesNullable
    {
        public static void Main122(string[] args)
        {
            int? nullableAge = null;

            nullableAge = 20;
            if (nullableAge.HasValue)
            {
                Console.WriteLine($"Age: {nullableAge.Value}");

            }
            else
            {
                Console.WriteLine("Age is not specified.");
            }
        }
    }
}
