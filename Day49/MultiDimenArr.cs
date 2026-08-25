using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ConsoleApp1.Day49
{
    internal class MultiDimenArr
    {
        public static void Main234(string[] args)
        {
            int [,] marks = { { 1, 2, 34 }, { 1, 3, 4 }, { 4, 5, 6 }, { 7, 8, 9 } };


            for (int i = 0; i < marks.GetLength(0); i++) {
                for (int j = 0; j < marks.GetLength(1); j++) {
                    Console.WriteLine(marks[i,j]);
                }
            }

        }
    }
}
