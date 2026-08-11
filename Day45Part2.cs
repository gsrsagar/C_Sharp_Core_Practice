using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Day45Part2
    {
        //Primitive Data types
        // int , char,bool , float, double 
        int age = 20; // 4 bytes , -273373782 to +
        char gender = 'm';    // 2 bytes ( -128 to 127 ) (256) // Unicode
                              // 0   0  0 0 0 0 0 0 0  (2^0 - 2^7)
        bool isDone = true; // 1bit  1 byte = 8 bits ( 128 64 32 16 8 4 2 0 ) (0-255)
        string name = "Sagar"; // 4 bytes
        float marks = 99.5f; // 4 bytes 
        double avgMarks = 2939490340923.4; // 8 bytes
        long mobileNumber = 7680919598; // 8 bytes 
        // Primitive

        //Non Primitive 
        // class types or custom types / user defined types

        public static void Main12(string[] args)
        {
            Student1 s = new Student1(); // Non Primitire / Class type // Refernce type / Custom Type
            s.type = Payments.UPI;
            Console.WriteLine(s.id);
            Console.WriteLine(s.type);
        }
        
    }

    
    public class Student1
    {
        public int id { get; set; }
        public string? name { get; set; }
        public Payments type { get; set; }
    }

    public enum Payments
    {
        UPI ,
        CREDIT_CARD,
        DEBIT_CARD,
        PAYPAL
    }
}
