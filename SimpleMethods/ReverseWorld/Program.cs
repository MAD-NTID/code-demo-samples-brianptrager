using System;

namespace ReverseWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Reverse World!");

            ReverseFirstName();
            ReverseLastName();
        }

        public static void ReverseFirstName()
        {
            Console.Write("Enter your first name: ");
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
        }

        public static void ReverseLastName()
        {
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            char[] lastNameChars = lastName.ToCharArray();
            Array.Reverse(lastNameChars);
            //char c = 'B';
            string reverseLastName = "";
            foreach (char c in lastNameChars)
            {
                reverseLastName += c;
                //Console.Write(c);
            }
            Console.Write(reverseLastName);
        }
    }
}
