using System;

namespace VoidMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am an argument/parameter 1 and I'm called from a method");
            Console.Read();
        }

        //access modifier,(static - bc the Main method is static), 
        //return type (void), method name
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
            
        }

        //return type (void), method name (parameter1)
        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
           
        }
    }
}
