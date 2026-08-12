using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Iterations
    {
        public static void Main15(string[] args)
        {
            string[] courses = { "Dotnet", "Java", "Python", "MERN", "MEAN", "C", "ROadmaps" };
            //                   0 , 1, 2, 3, 4, 5, 6  < 7 = 6
            // for each element in courses print one by one 
            for(int a=0;a< courses.Length; a++)
            {
                Console.WriteLine(courses[a]);
            }

            // for(decleation ; conditon; incremeent){
            //  logic
            // }

            // foeach
            foreach(string course in courses)
            {
                Console.WriteLine(course);
            }


            string courseName = "Java Full Stack 90 days plan";
            foreach(char c in courseName)
            {
                Console.WriteLine(c);
            }
            //
            // while loop

            int batteryPercentage = 100;

            //while (batteryPercentage > 0)
            //{
            //    batteryPercentage--;
            //    Console.WriteLine("Consumed 1 percent");
            //}

           


            // do while 
            do
            {
                batteryPercentage--;
                Console.WriteLine("Consumed 1 percent");
            } while (batteryPercentage > 0);

            Console.WriteLine("Exited from battery to 0 percent");


            // 



        }
    }
}
