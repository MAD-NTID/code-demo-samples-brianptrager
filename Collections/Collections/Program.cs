using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            //numbers.Add(5);
            //numbers.Add(8);
            int n;
            while(true)
            {
                Console.Write("Enter a number: ");
                if ((n = int.Parse(Console.ReadLine())) != -99)
                    numbers.Add(n);
                else
                    break;
            }

            //int[] numbers2 = new int[50000];

            Console.WriteLine($"There are {numbers.Count} elements in the list");

            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
