using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class JumpStatements
    {
        public static void Main17(string[] args)
        {
            int a = 5;

            for(int i = 0; i <= 20; i++)
            {
                if (i % a == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }

                Console.WriteLine("Printed 5 disivble");
            }

            int b = 5;
            //  break
            for (int i = 0; i <= 20; i++)
            {
                if (i ==b )
                {
                    Console.WriteLine("found 5 ");
                    break;
                } else
                {
                    continue;
                }
                

                
            }
        }
    }
}
