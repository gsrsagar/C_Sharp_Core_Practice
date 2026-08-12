using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day48
{
    internal class MethodsExp
    {
        // Methods are Re-usabale Functions 
         // Main is a method , method is a block of code to execute something

        public static double Add(double a , float b)
        {
            return a+b;
        }

        public double MultiPlyTwoNumbers(double a, float b)
        {
            return a + b;
        }
        // scope  static returntype methodName(param1TDattype param1name ,
        // param2Datatype parame2name){ // method Declaration

        // logic implementation 
        // }

        public static void Main1234(string[] args)
        {
            MethodsExp m = new MethodsExp();
            double result = m.MultiPlyTwoNumbers(1, 3);
            double resultAddOPs = Add(100, 3);// arguments // Function Call / Method Call 
            Console.WriteLine(result);
            Console.WriteLine(resultAddOPs);
        }
    }
}
