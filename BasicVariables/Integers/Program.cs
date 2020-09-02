using System;

namespace Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 7;
            //int y = x + 3;

            //Console.WriteLine(y);

            int age = 3;
            int dogAge = age * 7;

            int luckyNumber;
            luckyNumber = 14;


            Console.WriteLine("My age: " + age + " Dog age: " + dogAge);
            Console.WriteLine("Your lucky number is " + luckyNumber);
            Console.ForegroundColor = ConsoleColor.Cyan;
            luckyNumber = 17;
            Console.WriteLine("Human age: {0} Dog age: {1}\nYour lucky number is {2}", age, dogAge, luckyNumber);
            
        }
    }
}
