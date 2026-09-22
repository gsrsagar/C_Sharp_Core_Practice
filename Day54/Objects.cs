using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Day53
{
    internal class Objects
    {
        public static void Main22(string[] args)
        {
            Student s = new Student(20, "Senak360");
            Console.WriteLine(s); //Student@23823289
            Console.WriteLine($"Age: {s.Age}, Name: {s.Name}");
            Console.WriteLine(s.ToString()); //   ConsoleApp1.Day53.Student // 
            // Name : Senak360, Age : 20
            Console.WriteLine("s hashcode"+" "+s.GetHashCode());

            Student s1 = new Student(20, "Senak360");
            Console.WriteLine("s1 hashcode" + " " + s1.GetHashCode());
            Console.WriteLine("Are Equal"+ "  "+s.Equals(s1));
            Console.WriteLine(s.GetType()); // ConsoleApp1.Day53.Student
        }
    }
    // Object in built that is super for all classes existing and creating by you
    // C# , Java -> OOPS - Class and Objects -> 
    class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Age : {Age} , Name : {Name}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Student student &&
                   Age == student.Age &&
                   Name == student.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Age, Name);
        }
        public Student(int age, string name)
        {
            Age = age;
            Name = name;
        }
    }
}
