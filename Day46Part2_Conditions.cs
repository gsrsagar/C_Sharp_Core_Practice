using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Day46Part2_Conditions
    {
        public static void Main14(string[] args)
        {
            int balance = 100;
            int input = 101;
          //  Console.WriteLine("Enter amount to withdraw");
           // int input = Convert.ToInt32(Console.ReadLine());

            if(balance >= input)
            {
                Console.WriteLine("Withdraw Success");
                balance = balance - input;
                Console.WriteLine(balance);
            }
            else {
                Console.WriteLine("INsufficience balance");
            }

            // Multiple Conditions 
            // else if ladder 

            int age = 54;

            if(age>19 && age <= 30)
            {
                Console.WriteLine("Adult");
            } else if(age>30 && age <= 50)
            {
                Console.WriteLine("Mid Age Parents");
            } else if( age > 50 && age <= 99)
            {
                Console.WriteLine("grand parents");
            } else if(age<=19 && age >= 13)
            {
                Console.WriteLine("Teen age");
            } else if (age <= 10)
            {
                Console.WriteLine("Child age");
            } else
            {
                Console.WriteLine("IN Kailsam or Vikuntam");
            }


            // Switch Case 

            string option = "3";
            switch (option)
            {
                case "0": Console.WriteLine("selected 0"); break;
                case "1": Console.WriteLine("sleected 1"); break;
                case "2": Console.WriteLine("Slected 2"); break;
                default: Console.WriteLine("invalid"); break;
            }

        }
    }
}
