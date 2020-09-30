using System;

namespace BetterReverseWorld
{
    class Program
    {


        /*public static void ReverseThis(string message)
        {
            Console.Write($"{message}: ");
            string firstName = Console.ReadLine();

            char[] firstNameChars = firstName.ToCharArray();
            Array.Reverse(firstNameChars);
            //char c = 'B';
            string reverseName = "";
            foreach (char c in firstNameChars)
            {
                reverseName += c;
                //Console.Write(c);
            }

            Console.WriteLine(reverseName);
        }*/

        /*  Not a perfect method, too much copy and paste 
        public static void ReverseAll(string firstName, string lastName)
        {
            char[] firstNameChars = firstName.ToCharArray();
            Array.Reverse(firstNameChars);
            //char c = 'B';

            char[] lastNameChars = lastName.ToCharArray();
            Array.Reverse(lastNameChars);

            string reverseFirstName = "";
            string reverseLastName = "";
            foreach (char c in firstNameChars)
            {
                reverseFirstName += c;
                //Console.Write(c);
            }
            foreach(char c in lastNameChars)
            {
                reverseLastName += c;
            }

            Console.WriteLine(reverseFirstName);
            Console.WriteLine(reverseLastName);
        }*/

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Reverse World!");

            Console.Write("Enter your first name: ");
            string fn = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string ln = Console.ReadLine();
            Console.Write("What city do you live in: ");
            string city = Console.ReadLine();

            ReverseAll(fn, ln, city);
        }

        public static void ReverseAll(string firstName, string lastName, string city)
        {
            ReverseThis(firstName);
            ReverseThis(lastName);
            ReverseThis(city);
        }

        public static void ReverseThis(string word)
        {
            char[] wordChars = word.ToCharArray();
            Array.Reverse(wordChars);

            string reverseWord = "";

            foreach (char c in wordChars)
            {
                reverseWord += c;
            }

            Console.WriteLine(reverseWord);
        }

    }
}
