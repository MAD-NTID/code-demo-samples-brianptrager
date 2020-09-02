using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Brian";
            string favoriteFood = "pumpkin pie";
            string favoriteNumber = "14";

            //int dogAge = favoriteNumber * 7;

            Console.WriteLine("My first name is {0} and my favorite food is {1}.  " +
                "My lucky number in case I need it is {2}", firstName, favoriteFood, favoriteNumber);
        }
    }
}
