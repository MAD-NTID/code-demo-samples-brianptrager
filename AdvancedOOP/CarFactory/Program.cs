using System;
using System.Collections.Generic;

namespace CarFactory
{
    class Program
    {
        static List<Engine> engineList = new List<Engine>();
        static void Main(string[] args)
        {
            string menu = String.Format($"1. Build a car\n2. Add an engine\n3. Remove a car\n" +
                $"4. List all cars\n5. List all engines\n6. Exit\n\nEnter your option: ");

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
                        Engine selectedEngine = null;

                        if (engineList.Count > 0)
                        {
                            Console.Write("Select your engine: ");

                            DisplayEngines();
                            Console.Write("\nChoose your engine: ");
                            selectedEngine = engineList[int.Parse(Console.ReadLine()) - 1];
                        }
                        carList.Add(new Car(year, color, gtc, make, model, carType, selectedEngine));
                        break;

                    case 2: //Add an engine
                        Console.Write("Number of cylinders: ");
                        int nc = int.Parse(Console.ReadLine());
                        Console.Write("Fuel type: ");
                        string ft = Console.ReadLine();
                        Console.Write("Horsepower: ");
                        int hp = int.Parse(Console.ReadLine());
                        Console.Write("Engine size (L): ");
                        double engSize = double.Parse(Console.ReadLine());
                        engineList.Add(new Engine() { EngineSize = engSize, FuelType = ft, HorsePower = hp, NumCylinders = nc });
                        break;
                    case 3: //Remove a car
                        Console.Write($"Enter the number to remove a car (1 - {carList.Count}):");
                        int choice = int.Parse(Console.ReadLine());
                        carList.RemoveAt(--choice);
                        break;

                    case 4: //List all cars
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

                    case 5: //List all engines
                        DisplayEngines();
                        break;

                    case 6: //Exit the program - so easy a cave man can do this!  Sponsored by GEICO
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        continue;
                }
            }
        }//end Main

        public static void DisplayEngines()
        {
            int j = 1;
            foreach (Engine e in engineList)
            {

                Console.WriteLine($"{j}. {e}");
                j++;
            }
            Console.WriteLine("\n");
        }
    }
}
