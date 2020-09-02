using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter the first number: ");
            //int firstNum = int.Parse(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //int secondNum = int.Parse(Console.ReadLine());

            //if(firstNum > secondNum)
            //{
            //    Console.WriteLine("The first number is bigger.");
            //}

            //const int LEGAL_DRINKING_AGE = 21;

            //Console.Write("Enter your age: ");
            //int myAge = int.Parse(Console.ReadLine());

            //if(myAge >= LEGAL_DRINKING_AGE)
            //{
            //    Console.WriteLine("You are legally permitted to drink alcohol");
            //    Console.ReadLine();
            //    Environment.Exit(0);
            //}
            //Console.WriteLine("You are NOT legally permitted to drink alcohol");
            //Console.ReadLine();

            const string SECRET_PASSWORD = "ProfessorBTIsAwesome";

            Console.Write("Enter the password: ");
            string userPassword = Console.ReadLine();

            if(userPassword == SECRET_PASSWORD)
            {
                Console.WriteLine("Welcome to the secret club!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Sorry, you are not welcome.");
            Console.ReadLine();
        }
    }
}
