using System;

namespace SimpleMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessage();
            SuperSecretFormula("Pay attention");
            SuperSecretFormula("Do not fall asleep");
        }

       /* private static void PrintHello()
        {
            Console.WriteLine("Hello World");
        }*/

        public static void PrintMessage()
        {
            Console.WriteLine("This is a message.");
            Console.WriteLine("You can do more than one statement.");
        }

        /*public static void SuperSecretFormula()
        {
            Console.WriteLine("The secret to passing this course is basically do the work.");
        }*/

        public static void SuperSecretFormula(string formula)
        {
            Console.WriteLine($"Secret Formula: {formula}");
        }
    }
}
