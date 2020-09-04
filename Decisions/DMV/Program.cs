using System;

namespace DMV
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN_DRIVING_AGE = 16;
            int myAge;
            string hasLicense;

            Console.Write("Enter your age: ");

            if(int.TryParse(Console.ReadLine(), out myAge))
            {
                if (!(myAge < MIN_DRIVING_AGE))
                {
                    Console.Write("Do you have a license? (y/n): ");

                    hasLicense = Console.ReadLine();

                    if (myAge >= MIN_DRIVING_AGE && (hasLicense == "y" || hasLicense == "yes"))
                    {
                        Console.WriteLine("You are legally allowed to drive");
                    }
                    else
                    {
                        Console.WriteLine("You are NOT legally allowed to drive");
                    }
                }
                else
                {
                    Console.WriteLine("You're too young");
                }
            }
            else
            {
                Console.WriteLine("Invalid input, user did not enter a numerical value.");
            }
        }
    }
}
