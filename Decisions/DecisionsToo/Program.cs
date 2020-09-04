using System;

namespace DecisionsToo
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

            if(false)
            {
                Console.WriteLine("The first if statement is true"); ;
            }
            else
            {
                Console.WriteLine("The first statement is false");
            }

            const int LEGAL_DRINKING_AGE = 21;

            Console.Write("Enter your age: ");
            int myAge;
            //int myAge = int.Parse(Console.ReadLine());

            if(int.TryParse(Console.ReadLine(), out myAge))
            {
                if (myAge >= LEGAL_DRINKING_AGE)
                {
                    Console.WriteLine("You are legally permitted to drink alcohol");
                }
                else
                {
                    Console.WriteLine("You are NOT legally permitted to drink alcohol");
                }
            }
            else
            {
                Console.WriteLine("You know, I only asked for a number.  Is that too hard?");
            }

            Console.ReadLine();

            //const string SECRET_PASSWORD = "ProfessorBTIsAwesome";

            //Console.Write("Enter the password: ");
            //string userPassword = Console.ReadLine();

            //if (userPassword == SECRET_PASSWORD)
            //{
            //    Console.WriteLine("Welcome to the secret club!");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, you are not welcome.");
            //}

            //Console.Write("Who is Professor BT?");

            //const string ANOTHER_SECRET_PASSWORD = "Jedi Master";

            //if(Console.ReadLine() == ANOTHER_SECRET_PASSWORD)
            //{
            //    Console.WriteLine("Good answer, young padawan!");
            //}
            //else
            //{
            //    Console.WriteLine("I sense a disturbance in the force");
            //}

            //Console.ReadLine();
        }
    }
}
