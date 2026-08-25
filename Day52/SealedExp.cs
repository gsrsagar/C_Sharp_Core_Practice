using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day52
{
      class SealedExp
    {
        public  int age = 30;

        public virtual void Display()
        {
            Console.WriteLine("Display Age" + age);
        }
    }

    class SealedIMpl : SealedExp
    {
        public  sealed override void Display()
        {
            Console.WriteLine("Sealed Display Age" + age);

        }
        public static void Main112(string[] args)
        {
            SealedExp o = new SealedIMpl();
            o.Display();
        }

    }

    class SealedIMpl2 : SealedIMpl
    {
        
    }


}
