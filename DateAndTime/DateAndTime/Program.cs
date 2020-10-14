using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime.DayOfWeek);
            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.ToLongDateString());
            Console.WriteLine(dateTime.ToShortDateString());
            Console.WriteLine(dateTime.ToLongTimeString());
            Console.WriteLine(dateTime.ToShortTimeString());

            if(dateTime.DayOfWeek.ToString() == "Wednesday")
            {
                Console.WriteLine("This is a very special day!");
            }
        }
    }
}
