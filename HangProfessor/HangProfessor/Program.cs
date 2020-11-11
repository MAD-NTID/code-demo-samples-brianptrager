using System;

namespace HangProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "fall", "winter", "spring", "summer", "tiger", "semester" };
            Random rng = new Random();


            //Create a Hangman variable
            HangmanManager hangman;

            //Instantiate your HangmanManager variable.
            hangman = new HangmanManager(words[rng.Next(words.Length)]);

            do
            {
                Console.WriteLine(hangman.DisplayString);
                Console.Write("Enter a single character: ");
                char guess = char.Parse(Console.ReadLine());
                if(hangman.Guess(guess))
                    Console.WriteLine("Correct!");
                else
                    Console.WriteLine($"Cannot find the letter {guess}");
                //hangman.Guess(char.Parse(Console.ReadLine());

            }while(!hangman.GameOver);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Winner!");
        }
    }
}
