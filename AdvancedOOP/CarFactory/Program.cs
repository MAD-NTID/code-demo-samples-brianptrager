using System;
using System.Collections.Generic;

namespace CarFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = String.Format($"1. Build a car\n2. Remove a car\n" +
                $"3. List all cars\n4. Exit\n\nEnter your option: ");

            List<Car> carList = new List<Car>();

            while (true)
            {
                Console.Write(menu);

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1: //Build a car
                        Console.Write("Enter the year: ");
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("Enter the color of the car: ");
                        string color = Console.ReadLine();
                        Console.Write("Enter the car type: ");
                        string carType = Console.ReadLine();
                        Console.Write("Enter the make of the car: ");
                        string make = Console.ReadLine();
                        Console.Write("Enter the model of the car: ");
                        string model = Console.ReadLine();
                        Console.Write("Enter the gas tank capacity: ");
                        int gtc = int.Parse(Console.ReadLine());

                        carList.Add(new Car(year, color, gtc, make, model, carType));
                        break;

                    case 2: //Remove a car
                        Console.Write($"Enter the number to remove a car (1 - {carList.Count}):");
                        int choice = int.Parse(Console.ReadLine());
                        carList.RemoveAt(--choice);
                        break;

                    case 3: //List all cars
                        int i = 1;
                        foreach (Car c in carList)
                        {
                            Console.WriteLine($"============Car #{i}==============");
                            Console.WriteLine(c);
                            Console.WriteLine("");
                            i++;
                        }
                        Console.WriteLine("\n");
                        break;

                    case 4: //Exit the program - so easy a cave man can do this!  Sponsored by GEICO
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        continue;
                }
            }
        }
    }
}
