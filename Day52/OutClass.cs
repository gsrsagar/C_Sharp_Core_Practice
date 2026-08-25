using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp1.Day52
{
    class OutClass
    {

        private long balance { get; set; }

        public long getBalance() { return balance; }

        public class  InnnerClass1
        {
            public string name = "Sagar";

           
        }


        public  static void Main121(string[] args)
        {
            OutClass o = new OutClass();
            OutClass.InnnerClass1 obj = new  OutClass.InnnerClass1();

            Console.WriteLine(obj.name);
        }
    }
}
