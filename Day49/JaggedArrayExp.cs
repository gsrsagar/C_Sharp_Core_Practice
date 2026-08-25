using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day49
{
    internal class JaggedArrayExp
    {
        public static void Main223(string[] args)
        {
            int[][] arr = new int[3][]; // 1 ,2 ,3 
            arr[0] = new int[3] { 1, 2, 3 };
            arr[1] = new int[4] { 1, 3, 4, 4 };
            arr[2] = new int[5] { 1, 2, 3, 4, 5 };
            /**
               {
                  {1,2,3},
                  {1,3,4,4},
                  {1,2,3,4,5}
                }
             */
            foreach (var elements in arr)
            {
                // { 1, 2, 3 };
                foreach (var element in elements)
                {
                    Console.Write(element);
                }
                Console.WriteLine();
            }
        }
        }
}
