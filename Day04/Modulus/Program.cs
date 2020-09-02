using System;

namespace Modulus
{
    class Program
    {
        static void Main(string[] args)
        {
            int remainder = 5 % 3;

            Console.WriteLine(remainder);

            int remainder2 = 100 % 25;

            Console.WriteLine(remainder2);

            int total = (5 * 7) / 2 + 15 - 4 ^ 2;
            Console.WriteLine(total);

            double total2 = 15 / 2.0;
            Console.WriteLine(total2);

            double wholeNumber = 7.5;
            Console.WriteLine(wholeNumber);
        }
    }
}
