

using System;
using System.Collections;

namespace ConsoleApp1.Day48
{
    internal class NameSpaceExp
    {
        public static void Main124(string[] args)
        {
            Student s = new Student();
            s.age = 39;
            Console.WriteLine(s.age);

            Payments p = Payments.UPI;
            Console.WriteLine(p);

            DateTime t = new DateTime();
            Console.WriteLine(t);

            ArrayList l = new ArrayList();
            l.Add(6);
            l.Add("Sagar");
            l.Add(5);
            foreach (var i in l) {
                Console.WriteLine(i);
            }

            int[] arr = { 1, 2, 3, 45, 65, 7, 8, 8, 9, 8, 50 };
            var result = arr.Where(x => x % 2 == 0);
            foreach(var element in result)
            {
                Console.WriteLine(element);
            }

        }
    }
}
