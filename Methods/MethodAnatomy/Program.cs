using System;

namespace MethodAnatomy
{
    class Program
    {
        public static string something = "This is something";
        
        static void Main(string[] args)
        {
            string somethingSpecial = "This is very special!";
            DoSomething(somethingSpecial);
            Console.WriteLine(something);
        }

        public static void DoSomething(string something1)
        {
            Console.WriteLine($"{something}");
            Console.WriteLine($"{something1}");
        }
    }
}
