
using AcessExampels;

namespace ModifiersNameSpace {

    public class Modifiers1 {
        public static void Main122(string [] args){
            Console.WriteLine("Hi");

            ExamplesAccess obj = new ExamplesAccess();
            obj.age = 23;
            Console.WriteLine(obj.age);
        }
    }
}