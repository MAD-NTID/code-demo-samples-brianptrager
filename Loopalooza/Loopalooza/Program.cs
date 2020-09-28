using System;

namespace Loopalooza
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int i = 0;
            int total = 0;

            while(i < numbers.Length)
            {   
                Console.WriteLine(numbers[i]);
                total += numbers[i];
                i++;
            }

            Console.WriteLine(total);
            /*
            int j = 0;

            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 10);*/
        }
    }
}
