using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //i++: i = i + 1
            /*
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for(int i = 20; i >= 0; i--)
            {
                Console.WriteLine(i);
            }*/

            //i+=5: i = i + 5;
            /*
            for(int i = 0; i <= 100; i+=5)
            {
                Console.WriteLine(i);
            }

            for(int i=1; i <= 1000; i+=i)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i <= 1000; i++)
            {
                if((i % 25) == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }

                Console.WriteLine(i);
                Console.ResetColor();
            }*/

            Console.Write("Enter a number to begin: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i <= num; i++)
            {
                Console.WriteLine(i);
            }


        }
    }
}
