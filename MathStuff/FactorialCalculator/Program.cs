using System;

namespace FactorialCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nn represents the product of the first n integers.");
            int n = 0;
            int factorial = 1;

            while(true)
            {
                Console.Write("Enter the number to use to compute n: ");
                while(!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.Write("Invalid input, Try again.  Enter a valid integer value: ");
                }

                for(int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine($"The factorial of {n} is {factorial}.");

                Console.WriteLine($"\nDo you want to calculate another factorial?\nEnter y for another calculation.\nAny other character to stop this program.");

                if (Console.ReadLine().ToUpper() != "Y")
                    break;
            }
        }
    }
}
