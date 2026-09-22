using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ConsoleApp1.Day53
{
    internal class ProcessExp
    {
        public static void Main22(string[] args)
        {
            Process.Start("notepad.exe");
            Process.Start("calc.exe");

            Process [] processes = Process.GetProcesses();
            foreach(var p in processes)
            {
                Console.WriteLine($"Process Name: {p.ProcessName}, ID: {p.Id}");
            }

            foreach(var p in processes)
            {
                if (p.ProcessName == "notepad" || p.ProcessName == "calc")
                {
                    Console.WriteLine($"Killing process: {p.ProcessName}, ID: {p.Id}");
                    p.Kill();
                }

            };

            string videoPath = @"C:\Users\user\Downloads\Sagar Stack - Sep 19th - 700 pm Live.mp4";
            Process.Start(new ProcessStartInfo
            {
                FileName = videoPath,
                UseShellExecute = true
            });
        }
    }
}
