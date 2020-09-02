using System;

namespace Constants
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DAYS_IN_A_WEEK = 7;
            int numWeeks = 52;

            Console.WriteLine("Number of days: {0}", DAYS_IN_A_WEEK * numWeeks);
        }
    }
}
