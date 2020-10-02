using System;

namespace ReturningMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The POWER Calculator");
            //Console.Write("Enter the first number: ");
            //int num1 = int.Parse(Console.ReadLine());
            while (true)
            {
                int num1 = readInt("Enter the first number: ");
                int num2 = readInt("Enter the second number: ");
                //Console.Write("Enter the second number: ");
                //int num2 = int.Parse(Console.ReadLine());

                //Console.WriteLine(num1);
                //Console.WriteLine(num2);
                long result = DoPow(num1, num2);
                Console.WriteLine($"{result}");

                if(DoPow(num1, num2, out result))
                {
                    Console.WriteLine($"Valid number: {result}");
                }
                else
                {
                    Console.WriteLine("Cannot compute with number given.");
                }

                Console.Write("Would you like to run the program again? (y/n): ");
                if (!(Console.ReadLine().ToUpper() == "Y"))
                    break;
            }
        }

        private static int readInt(string prompt)
        {
            Console.Write(prompt);
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        private static long DoPow(int n1, int n2)
        {
            long result = 1;
            for(int i = 0; i < n2; i++)
            {
                result *= n1;
            }
            return result;
        }

        private static bool DoPow(int n1, int n2, out long result)
        {
            result = 1;
            for (int i = 0; i < n2; i++)
            {
                result *= n1;
            }
            if(result == 0)
                return false;

            return true;
        }
    }
}
