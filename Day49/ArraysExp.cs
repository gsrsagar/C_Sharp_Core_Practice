using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day49
{
    internal class ArraysExp
    {
        public static void Main233(string [] args)
        {
            // declaration 
            // datatype [] varname  = new datatype[10];
            // its fixed size by default 

            // with out fixed 

            int[] nums = new int[10]; // fixed declaratrion

            // index starts with 0,1,2,3,4,5,6,7,8,9
            nums[0] = 1;
            nums[1] = 2;
            nums[9] = 99;
            //nums[10] = 100; // Array index out of bound exception 
            Console.WriteLine(nums);
            for (int i = 0; i < nums.Length; i++) { 
                Console.WriteLine(nums[i]);
            }

            float[] marks = new float[10];
            marks[0] = 10.32f;
            marks[4] = 10.11f;
            foreach( float element in marks)
            {
                Console.WriteLine(element);
            }

            int[] numbers = { 1, 2, 34, 65, 7, 8, 9, };
            int len = numbers.Length;
            foreach(var element in numbers)
            {
                Console.WriteLine(element);
            }


            string[] courses = { "DOtnet", "Java", "Python" };
            foreach(var course in courses)
            {
                Console.WriteLine(course);
            }


        }
    }
}
