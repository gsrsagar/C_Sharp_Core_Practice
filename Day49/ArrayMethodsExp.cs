using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day49
{
    internal class ArrayMethodsExp
    {
        public static void Main12(string[] args)
        {
            int[] arr = { 1, 2, 34, 5, 6, 7, 8 };
            int len = arr.Length;

            Console.WriteLine(len);
            int[] cloned = (int[])arr.Clone();

            Array.Sort(arr);
            Array.Reverse(arr);
            Array.Clear(arr, 1, 3);
            int ind = Array.IndexOf(arr, 34);
            Console.WriteLine(ind);

            int[] result = Array.FindAll(arr, num => num % 2 == 0);
            foreach(var e in result)
            {
                Console.WriteLine("Diuvided by 2 ", e);
            }
            foreach(var e in arr)
            {
                Console.WriteLine(e);
            }

            foreach(var e in cloned)
            {
                Console.WriteLine(e);
            }
          //  Console.WriteLine(arr);

        }
    }
}
