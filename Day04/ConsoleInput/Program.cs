using System;

namespace ConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ResetColor();
            Console.Title = "What's your name?";

            Console.Write("Enter your name: ");
            //string name = "Professor BT";
            Console.ForegroundColor = ConsoleColor.Magenta;
            string name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Your name is {0}", name);

            Console.ResetColor();
            Console.Write("Enter your favorite number: ");
            string favNum = Console.ReadLine();

            Console.WriteLine("Your lucky number is {0}", favNum + favNum);
            
            Console.ReadLine();

            
        }
    }
}
