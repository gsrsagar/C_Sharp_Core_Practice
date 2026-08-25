using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day51
{
    internal class EncapExp
    {
    }

    class Bank
    {
        private int balance;
        protected long accNO;

        private string name="";  // Data Member are nothing but 
        // variables

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
      
        public int GetBalance()
        {
            return balance;
        }

        public static void Main1223(string[] args)
        {
            Bank bank = new Bank();
            bank.Name = "SUnil";
            Console.WriteLine(bank.GetBalance());
            Console.WriteLine(bank.Name);
        }

    }
}
