using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day48
{
    public delegate void Notify(); // delegate
    internal class DelegatesExp
    {
        
        public static void Main(string[] args)
        {
            Process p = new Process();
           
            p.ProcessCompleted += () => Console.WriteLine("Process Keyboard entered");
             p.ProcessCompleted += () => Console.WriteLine("Process Ligthing entered");
            p.ProcessCompleted += () => Console.WriteLine("Process Mosued entered");
            p.ProcessCompleted += () => Console.WriteLine("Process Print entered");
            p.ProcessStart();

        }
    }

    class Process
    {
        public event Notify ProcessCompleted;

        public void ProcessStart()
        {
            Console.WriteLine("Start Process");
            ProcessCompleted?.Invoke();
        }
    }
}
