using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day52
{
     class RestrictVairablesExp
    {

        public readonly int age =20;
        public const int PI = 123;
       

        public RestrictVairablesExp(int age)
        {
            this.age = age;
        }

        public void Display()
        {
            //PI = 123334;
         /// age = 33430;
        }
        public static void Main12(string[] args)
        {
            RestrictVairablesExp o = new RestrictVairablesExp(2123);
            Console.WriteLine(o.age);
        }


    }
}
