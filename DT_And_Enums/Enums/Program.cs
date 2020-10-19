using System;

namespace Enums
{
    class Program
    {
        enum Levels
        {
            Low,
            Medium,
            High
        }

        enum Months
        {
            January,
            February,
            March=6,
            April,
            May,
            June,
            July
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Hello World!");
            //Console.WriteLine(Levels.High);
            //Console.WriteLine((int)Levels.High);

            switch(Levels.Medium)
            {
                case Levels.Low: Console.WriteLine("The level is low");
                    break;
                case Levels.Medium:
                    Console.WriteLine("The level is medium");
                    break;
                case Levels.High:
                    Console.WriteLine("The level is high");
                    break;
            }
            Console.WriteLine((int)Months.February);
            Console.WriteLine((int)Months.May);
            Console.WriteLine(Months.May);

            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (int i in Enum.GetValues(typeof(Months)))
            {
                Console.Write($" {i}: ");
                Console.WriteLine(Enum.GetName(typeof(Months), i));
            }
            /*
            foreach (string name in Enum.GetNames(typeof(Months)))
            {
                Console.WriteLine(name);
            }*/

            
        }
    }
}
