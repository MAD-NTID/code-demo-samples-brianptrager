using System;
using System.Collections.Generic;
using System.IO;

namespace CarRecords
{
    class Program
    {
        static List<Engine> engineList = new List<Engine>();
        static void Main(string[] args)
        {
            string menu = String.Format($"1. Build a car\n2. Add an engine\n3. Remove a car\n" +
                $"4. List all cars\n5. List all engines\n6. Update records\n7. Exit\n\nEnter your option: ");

            List<Car> carList = new List<Car>();
            string file = "carRecords.txt";
            //load data from a file into a carList
            LoadData(file, carList);

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

                    case 6: //Update records
                        SaveRecords(file, carList);
                        break;
                    
                    case 7: //Exit the program - so easy a cave man can do this!  Sponsored by GEICO
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        continue;
                }
            }
        }//end Main

        private static void LoadData(string file, List<Car> carList)
        {
            if (File.Exists(file))
            {
                using (StreamReader reader = new StreamReader(file))
                {

                    string line = null;
                    string[] carData = null;
                    Engine engine = null;

                    while ((line = reader.ReadLine()) != null)
                    {
                        carData = line.Split(',');
                        engine = new Engine()
                        {
                            EngineSize = double.Parse(carData[6]),
                            NumCylinders = int.Parse(carData[7]),
                            FuelType = carData[8],
                            HorsePower = int.Parse(carData[9])
                        };
                        carList.Add(new Car(int.Parse(carData[0]), carData[1],
                            int.Parse(carData[2]), carData[3], carData[4], carData[5],
                            engine));

                        //TODO: Check for duplicate engine
                        if (engineList.Count == 0)
                        {
                            engineList.Add(engine);
                        }
                        bool engineFlag = false;
                        for(int i = 0; i < engineList.Count; i++)
                        {
                            Engine e = engineList[i];
                            if ((e.EngineSize == engine.EngineSize && e.NumCylinders == engine.NumCylinders && e.FuelType == engine.FuelType && e.HorsePower == engine.HorsePower))
                            {
                                engineFlag = true;
                            }
                        }
                        if(!engineFlag)
                        {
                            engineList.Add(engine);
                        }
                        //Prof BT debugged and found a simple error -- DUH!
                        //carList.Add(new Car(int.Parse("2017"), "black", int.Parse("34"), "Ford", "F-250", "truck", new Engine() { EngineSize = int.Parse("6.7"), NumCylinders = 8, FuelType = "diesel", HorsePower = 440}));
                    }
                }
            }
        }

        private static void SaveRecords(string file, List<Car> carList)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Car car in carList)
                {
                    writer.WriteLine(car.ToCSVFormat());
                }
            }

            Console.WriteLine("Records successfully updated!");
        }

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
