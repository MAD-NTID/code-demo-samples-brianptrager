using System;
using System.IO;

namespace CSVFilesandArrays
{
    class Program
    {
        static int[] temperatures = new int[12];
        static void Main(string[] args)
        {
            while (true)
            {
                ReadFile();

                int total = 0;
                foreach (int t in temperatures)
                {
                    total += t;
                }

                Console.WriteLine($"The average temperature for the year in Rochester, NY is {total / temperatures.Length}");

                Console.Write("Does the file needs to be updated? (y/n): ");

                if (Console.ReadLine().ToLower() == "y")
                {
                    UpdateTemperature();
                    WriteFile();
                    Console.WriteLine("File has been updated");
                }
                else
                    break;
            }//end outer loop

        }//end Main

        public static void ReadFile()
        {
            string line = null;
            using (StreamReader reader = new StreamReader("temperaturesCSV.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    for (int i = 0; i < temperatures.Length; i++)
                    {
                        temperatures[i] = int.Parse(values[i]);
                    }
                }
            }
        }

        public static void WriteFile()
        {
            using (StreamWriter writer = new StreamWriter("temperaturesCSV.txt"))
            {
                for (int i = 0; i < temperatures.Length; i++)
                {
                    if(i != temperatures.Length - 1)
                        writer.Write($"{temperatures[i]},"); //write a number each line
                    else
                        writer.Write($"{temperatures[i]}");
                }
            }
        }

        public static void UpdateTemperature()
        {
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {temperatures[i]}");
            }

            Console.Write("\nWhich temperature would you like to change? ");
            int index = int.Parse(Console.ReadLine());

            Console.Write("Enter the new temperature value: ");
            int newTemperature = int.Parse(Console.ReadLine());

            temperatures[index - 1] = newTemperature;
        }
    }
}
