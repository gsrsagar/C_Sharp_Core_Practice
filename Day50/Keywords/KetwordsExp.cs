using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day50.Keywords
{
    internal class KetwordsExp : Abstract

    {
        public  override int Deposit(int amount)
        {
            balance += amount;
            return amount;
        }

        public override int GetBalance()
        {
            return balance;
        }
        public static void Main122(string[] args)
        {
            Abstract o = new KetwordsExp();
             o.Deposit(200);
            Console.WriteLine(o.GetBalance());

        }
    }

    abstract class Abstract
    {

        protected int balance { get; set; }

        public abstract int Deposit(int amount);
        public abstract int GetBalance();
    }

   
}
