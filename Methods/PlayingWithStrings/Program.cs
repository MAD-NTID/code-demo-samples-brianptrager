using System;

namespace PlayingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //String str = "animal";
            //String toFind = "a";
            Console.Write("Enter a string: ");
            String str = Console.ReadLine();

            Console.Write("Enter the character you wish to find: ");
            String toFind = Console.ReadLine();

            Console.WriteLine(SearchChar(str, toFind));

        }

        private static string SearchChar(string str, string toFind)
        {
            int index = str.IndexOf(toFind);
            if (index == -1)
            {
                return String.Format($"Cannot find {toFind} in {str}");
            }
            else
            {
                return String.Format("Found '{0}' in '{1}' at position {2}",
                                toFind, str, index);
            }
        }
    }
}
