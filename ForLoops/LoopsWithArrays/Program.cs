using System;

namespace LoopsWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] classList = { "Tyler Ackerina", "Emily Oesterling", "Conor Doherty", "Izzy Pedrizco-Carranza", "James Anderson", "Trey Lukitsch" };

            Console.WriteLine($"There are {classList.Length} students in the class.");

            for(int i=0; i < classList.Length; i++)
            {
                Console.WriteLine(classList[i]);
            }

            Console.Write("Enter the number of new students in your class?: ");
            int newAddition = int.Parse(Console.ReadLine());
            int oldArraySize = classList.Length;

            Array.Resize(ref classList, classList.Length + newAddition);

            //For loop to add new students to resized array
            for (int i=0; i < newAddition; i++)
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
            }
        }
    }
}
