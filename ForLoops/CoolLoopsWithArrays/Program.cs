using System;

namespace CoolLoopsWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] classList = { "Tyler Ackerina", "Emily Oesterling", "Conor Doherty", "Izzy Pedrizco-Carranza", "James Anderson", "Trey Lukitsch" };

            Console.Write("How many students are in your class?: ");
            int classSize = int.Parse(Console.ReadLine());

            string[] classList = new string[classSize];

            //int[] numArray = new int[10]; //creates an array of 10 elements that only stores integers

            for(int i = 0; i < classList.Length; i++)
            {
                Console.Write($"Enter student {i + 1}: ");
                classList[i] = Console.ReadLine();
            }

            Console.WriteLine($"There are {classList.Length} students in the class.");

            for (int i = 0; i < classList.Length; i++)
            {
                Console.WriteLine(classList[i]);
            }

           /* Console.Write("Enter the number of new students in your class?: ");
            int newAddition = int.Parse(Console.ReadLine());
            int oldArraySize = classList.Length;

            Array.Resize(ref classList, classList.Length + newAddition);

            //For loop to add new students to resized array
            for (int i = 0; i < newAddition; i++)
            {
                Console.Write($"{i + 1}. Student's Name: ");
                classList[oldArraySize + i] = Console.ReadLine();
            }

            //newAddition = newAddition + classList.Length
            newAddition += classList.Length;

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"There are {classList.Length} students in the class.");
            for (int i = 0; i < classList.Length; i++)
            {
                Console.WriteLine(classList[i]);
            }*/
        }//end Main
    }
}
