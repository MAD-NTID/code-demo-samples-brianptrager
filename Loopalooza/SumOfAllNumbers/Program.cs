using System;

namespace SumOfAllNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int goodNum;
            int total = 1;

            while(true)
            {
                Console.Write("Enter a number: ");

                if (int.TryParse(Console.ReadLine(), out goodNum))
                {
                    if (goodNum < 0)
                    {
                        Console.WriteLine("Number cannot be negative, please enter a positive number");
                    }
                    else
                        break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number.");
                }
            }

            int i = 1;
            while(i <= goodNum)
            {
                total *= i;
                i++;
            }

            Console.WriteLine(total);
            
            /*
            while((!int.TryParse(Console.ReadLine(), out goodNum)) || goodNum < 0)
            {
                if (goodNum < 0)
                {
                    Console.WriteLine("Number cannot be negative, please enter a positive number");
                    Console.Write("Enter a number: ");
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number.");
                    Console.Write("Enter a number: ");
                }
            }*/





        }
    }
}
