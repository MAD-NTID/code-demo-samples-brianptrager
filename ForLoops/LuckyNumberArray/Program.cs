using System;

namespace LuckyNumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_GUESS_ATTEMPTS = 10;
            const int MAX_NUMBER = 100;

            int[] luckyNumbers = new int[3];
            Random random = new Random();

            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                luckyNumbers[i] = random.Next(MAX_NUMBER);
            }
            
            int currentGuess = 0;

            Console.WriteLine($"You get {MAX_GUESS_ATTEMPTS} tries to guess a number between 1 and {MAX_NUMBER}.\n");

            for (int i = 1; i <= MAX_GUESS_ATTEMPTS; i++)
            {
                Console.Write($"Lucky guess #{i}: ");
                currentGuess = int.Parse(Console.ReadLine());

                for (int j = 0; j < luckyNumbers.Length; j++)
                {
                    if (currentGuess == luckyNumbers[j])
                    {
                        int grandNumber = 0;

                        for(int k = 0; k < luckyNumbers.Length; k++)
                        {
                            grandNumber += luckyNumbers[k];
                        }
                        Console.WriteLine("You are SO LUCKY!!!  Nicely done and congrats!");
                        Console.WriteLine("Make a lucky guess for $10 MILLION DOLLARS!!!: ");
                        if(int.Parse(Console.ReadLine()) == grandNumber)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("HOLY COW!!  You WON $10 MILLION DOLLARS!!");
                        }
                        else
                        {
                            Console.WriteLine($"Sorry, but the grand lucky number is {grandNumber}.");
                        }

                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else if (currentGuess == -1)
                    {
                        foreach (int lucky in luckyNumbers)
                        {
                            Console.Write($"{lucky} ");
                        }
                    }
                }
            }

            Console.Write($"Not your lucky day!  The lucky number are ");
            foreach(int lucky in luckyNumbers)
            {
                Console.Write($"{lucky} ");
            }

            //int luckyNumber = random.Next(MAX_NUMBER);

            /*for(int i = 1; i <= MAX_GUESS_ATTEMPTS; i++)
            {
                Console.Write($"Lucky guess #{i}: ");
                currentGuess = int.Parse(Console.ReadLine());

                if (currentGuess == luckyNumber)
                {
                    Console.WriteLine("You are SO LUCKY!!!  Nicely done and congrats!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else if(currentGuess > luckyNumber)
                {
                    Console.WriteLine("Too high, guess lower.");
                }
                else
                {
                    Console.WriteLine("Too low, guess higher.");
                }
            }

            Console.WriteLine($"Not your lucky day!  The lucky number is {luckyNumber}");*/
        }
    }
}
