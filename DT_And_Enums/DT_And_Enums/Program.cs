using System;

namespace DT_And_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dt = new DateTime(); //January 1, 0001 (Monday)

            //DateTime dt = new DateTime(2020, 9, 12);
            DateTime dt = new DateTime();

            Console.Write("Enter the date of your birth: ");
            string dtInput = Console.ReadLine();


            //if(DateTime.TryParse("09/20/2020", out dt))
            if (DateTime.TryParse(dtInput, out dt))
            {
                dt = dt.AddYears(20);
                Console.WriteLine(dt.ToLongDateString());
                Console.WriteLine(dt.ToShortDateString());
                Console.WriteLine(dt.DayOfYear);
            }
            else
                Console.WriteLine("Invalid date format");

            /*
            DateTime dt = DateTime.Parse("09/30/2020", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(dt.ToLongDateString());
            Console.WriteLine(dt.ToShortDateString()); */
        }
    }
}
