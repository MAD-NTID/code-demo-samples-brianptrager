using System;

namespace EndOfTheWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.ResetColor();
                Console.Write("Enter code: ");

                if (Console.ReadLine() == "4 8 15 16 23 42")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Code accepted.  Timer reset.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect code.  One minute deducted.");

                }
            }
        }

    }
}
