using System;
/*
 * Name: Brian Trager
 * Date: Aug 31, 2020 - Last day of August!
 * Purpose: Wrap up the basics!
 * Caveats: I may miss a few
 */
namespace MathStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Good morning, what is your name? ");
            Console.ForegroundColor = ConsoleColor.Green;
            string fullName = Console.ReadLine();

            Console.ResetColor();
            //Console.WriteLine("Hello " + fullName + "! How can I help you?");
            //Console.WriteLine("Hello {0}! How can I help you?", fullName);
            Console.Write($"Hello {fullName}! How old are you? ");
            Console.ForegroundColor = ConsoleColor.Green;
            int myAge = int.Parse(Console.ReadLine());

            const int CURRENT_YEAR = 2020;

            int birthYear = CURRENT_YEAR - myAge;
            Console.ResetColor();
            Console.WriteLine($"You were born in {birthYear}.");

            Console.Write("What is your annual salary? ");
            Console.ForegroundColor = ConsoleColor.Green;
            double salary = double.Parse(Console.ReadLine());
            const double INFLATION_RATE = 0.02;

            Console.ResetColor();
            Console.WriteLine("In " + myAge + " years, you will be " + (myAge + myAge) + " years old.");

            Console.WriteLine($"In {myAge} years, your salary will be very roughly {salary + ((salary * INFLATION_RATE) * myAge):C}");
            
            //Console.WriteLine(@"You can find a secret file in C:\Users\007\goldeneye.dat");
            //Console.WriteLine("You\nare\nlearning\nsome\ncool\nstuff\today");
            
            double randomResult = Math.PI * myAge;

            randomResult = Math.Floor(randomResult);

            Console.WriteLine($"Random number: {randomResult}");
            //Console.WriteLine(24 / 10.0);
            Console.WriteLine($"Random number after explicit conversion: {(int)randomResult}");
            Console.ReadLine();
        }
    }
}
