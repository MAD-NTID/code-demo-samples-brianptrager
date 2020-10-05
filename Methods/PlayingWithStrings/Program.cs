using System;

namespace PlayingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "animal";
            String toFind = "a";
            int index = str.IndexOf(toFind);
            if (index == -1)
            {
                Console.WriteLine($"Cannot find {toFind} in {str}");
            }
            else
            {
                Console.WriteLine("Found '{0}' in '{1}' at position {2}",
                                toFind, str, index);
            }

        }
    }
}
