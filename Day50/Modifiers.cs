
using AcessExampels;
using System.Runtime.Remoting;

namespace ModifiersNameSpace {

    public class Modifiers {
        public static void Main123(string [] args){
            Console.WriteLine("Hi");

            ExamplesAccess obj = new ExamplesAccess();
            obj.age = 23;
            Console.WriteLine("Deposited"+ obj.Deposit(500));
            Console.WriteLine(obj.GetBalance());
            Console.WriteLine(obj.age);
        }
    }
}