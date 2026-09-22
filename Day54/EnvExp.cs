using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day53
{
    internal class EnvExp
    {
        public static void Main11(string[] args)
        {
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine(Environment.MachineName);
            Environment.Exit(0);
            Console.WriteLine("This line will not be executed because the application has exited.");

        }
    }
}
