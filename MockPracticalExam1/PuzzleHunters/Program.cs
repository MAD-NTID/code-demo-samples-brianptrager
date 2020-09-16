using System;

/*
 * Name: Professor Brian Trager
 * Date: 9/16/2020
 * Course: Programming Fundamentals I: Mobile Domain
 * Purpose: Keep track of total value of inventory in the store
 * Caveat: I did so well that it doesn't count for my grade :(
 */

namespace PuzzleHunters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int numStorePuzzleGames = 0;
            const double PUZZLE_GAME_PRICE = 19.95;
            double totalValue;
            string option;
            

            string menu = "\n1. Purchase puzzle games from the customers\n" +
                "2. Sell puzzle games to the customers\n" +
                "3. Display the current value of the inventory\n\n" +
                "Select one of the options: ";
            
            
            Console.Write("Enter the number of puzzle games currently in the store: ");
            Console.ForegroundColor = ConsoleColor.Green;
            numStorePuzzleGames = int.Parse(Console.ReadLine());
            Console.ResetColor();

            Console.Write(menu);
            Console.ForegroundColor = ConsoleColor.Green;
            option = Console.ReadLine();
            Console.ResetColor();

            //Determine follow up questions/messages based on option
            //You can alternatively use switch
            if(option == "1")
            {
                Console.Write("How many puzzle games would you like to purchase: ");
                Console.ForegroundColor = ConsoleColor.Green;
                numStorePuzzleGames = numStorePuzzleGames + int.Parse(Console.ReadLine());
                Console.ResetColor();
                /*
                 * int purchase = int.Parse(Console.ReadLine());
                 * numStorePuzzleGames = numStorePuzzleGames + purchase;
                 * OR
                 * numStorePuzzleGames += purchase;
                 */
            }
            else if(option == "2")
            {
                Console.Write("How many puzzle games would you like to sell: ");
                Console.ForegroundColor = ConsoleColor.Green;
                numStorePuzzleGames = numStorePuzzleGames - int.Parse(Console.ReadLine());
                Console.ResetColor();
                /*
                 * int purchase = int.Parse(Console.ReadLine());
                 * numStorePuzzleGames = numStorePuzzleGames - purchase;
                 * OR
                 * numStorePuzzleGames -= purchase;
                 */
            }
            
            //Calculate the total value based on puzzle games in inventory
            totalValue = numStorePuzzleGames * PUZZLE_GAME_PRICE;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPuzzle Game Inventory Valuation\n");
            Console.WriteLine($"Current number of puzzle games in the store: {numStorePuzzleGames}");
            Console.WriteLine($"Current Value: {totalValue:C}");
            Console.ResetColor();

            Console.ReadLine();
        }
    }
}
