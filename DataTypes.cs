using System; //this is namespace 
using System.IO; // this is namespace
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class DataTypes
    {
        public static void Main1122(string[] args)
        {
            Console.WriteLine("hi");
            Int64 age = 2147483647; // 4 bytes 32 bit
            //( - 2^63 to + 2^63)
            age = age + 1;
            age = age + 214748364;
            age = Int64.MinValue;

            double score = Convert.ToChar(Console.ReadLine() ?? string.Empty); // 4 bytes 
            double scroe = 20.5d; // 8 bytes

            bool isDone = true; // 1 bit 0
            Console.WriteLine("enter Name");
            string name = Console.ReadLine() ?? string.Empty;
            char c = 'A'; // 16 bits 2 bytes //  65 

            // Int 32 Range  ( -2147483648 to +2147483647) // unsigned 
            // 1 byte = 8 bits 
            //  128 64 32 16 8 4  2  1  ->
            //  2^0 - 2^7  1st byte
            //  2^8 - 2^15 2nd byte ( 16 bits = 2 bytes 1 byte = b=8 bits
            //  2^16 - 2^23  3rd Byte
            //  2^24 - 2^31 4th Byte
            float CONST_PI = 3.14f;
            Console.WriteLine(age);
            Console.WriteLine(score);
            Console.WriteLine(scroe);
            Console.WriteLine(isDone);
            Console.WriteLine(name);
            Console.WriteLine(CONST_PI);

        }
    }
}
