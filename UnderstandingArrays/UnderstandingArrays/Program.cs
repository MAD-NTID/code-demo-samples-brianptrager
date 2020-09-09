using System;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int num1, num2, num3, num4, num5;
            num1 = 1;
            num2 = 5;

            int number1 = 4;
            int number2 = 8;
            int number3 = 15;
            int number4 = 16;
            int number5 = 23;


            if(number1 == 16)
            {
                Console.WriteLine("Number 1 has it!");
            }
            else if(number2 == 16)
            { 
                Console.WriteLine("Number 2 has it!"); 
            }
            else if(number3 == 16)
            { 
                Console.WriteLine("Number 3 has it!"); 
            }
            else if(number4 == 16)
            { 
                Console.WriteLine("Number 4 has it!"); 
            }
            else if(number5 == 16)
            { 
                Console.WriteLine("Number 5 has it!"); 
            }
            else
            {
                //None of the numbers have a value of 16
                Console.WriteLine("None of them have it!");
            }
            */
            /*
            int[] numbers = new int[6];
            int[] numbers = {4, 8, 15, 16, 23, 42};
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            numbers[5] = 42;

            //int aNumber = numbers[2];
            //Console.WriteLine(numbers[2]);
            int total = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] + numbers[5];
            Console.WriteLine($"How big is the array?  Well, it has {numbers.Length} elements.");
            Console.WriteLine($"The total sum is {total}");
            */
            
            string[] manyFavoriteFood = new string[5];
            manyFavoriteFood[0] = Console.ReadLine();
            manyFavoriteFood[1] = Console.ReadLine();
            manyFavoriteFood[2] = Console.ReadLine();
            manyFavoriteFood[3] = Console.ReadLine();
            manyFavoriteFood[4] = Console.ReadLine();
            
            Random random = new Random();  //Create a Random Number Generator object
            int randomChoice = random.Next(manyFavoriteFood.Length);
            Console.WriteLine($"Favorite food of the day is {manyFavoriteFood[randomChoice]}");
            //Console.WriteLine($"{Int64.MaxValue}");

            /*
            Console.WriteLine(manyFavoriteFood[0]);
            Console.WriteLine(manyFavoriteFood[1]);
            Console.WriteLine(manyFavoriteFood[2]);
            Console.WriteLine(manyFavoriteFood[3]);
            Console.WriteLine(manyFavoriteFood[4]); */
            Console.ReadLine();
        }
    }
}
