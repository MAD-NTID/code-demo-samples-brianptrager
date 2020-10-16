using System;

namespace CarFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = String.Format($"1. Build a car\n2. Remove a car\n" +
                $"3. List all cars\n4. Exit\n\nEnter your option: ");

            Car myCar = null;
            Car[] cars = new Car[0];

            while(true)
            {
                Console.Write(menu);

                switch(int.Parse(Console.ReadLine()))
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
                        myCar = new Car(year, color, gtc, make, model, carType);
                        Array.Resize(ref cars, cars.Length + 1);
                        cars[cars.Length - 1] = myCar;
                        break;

                    case 2: //Remove a car
                        Console.Write($"Enter the number to remove a car (1 - {cars.Length}):");
                        int choice = int.Parse(Console.ReadLine());
                        //choice = choice - 1;
                        //Array.Clear(cars, --choice, 1);
                        for (int j = choice - 1; j < cars.Length - 1; j++)
                        {
                            cars[j] = cars[j + 1];
                        }
                        //Shift all car objects over by one based on choice
                        for(int k = choice; k < cars.Length; k++)
                        {
                            cars[choice - 1] = cars[choice];
                        }
                        //cars[choice] = null;
                        Array.Resize(ref cars, cars.Length - 1);
                        break;

                    case 3: //List all cars
                        int i = 1;
                        foreach(Car c in cars)
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

                    default: Console.WriteLine("Invalid option");
                        continue;
                }
            }

            //I want to create a car object
           /* Car myCar = new Car();
            
            myCar.Color = "Red";
            myCar.CarType = "SUV";
            myCar.Make = "Fordly";
            myCar.Model = "Explorer";
            myCar.GasTankCapacity = 18;
            myCar.Year = 100;
            myCar.IsRunning = true;
            myCar.Drive(250);
            Console.WriteLine("Data for the first car object");
            Console.WriteLine(myCar);
            //Console.WriteLine($"Color: {myCar.Color}");
            //Console.WriteLine($"Car Type: {myCar.CarType}");
            //Console.WriteLine($"Make: {myCar.Make}");
            //Console.WriteLine($"Model: {myCar.Model}");
            //Console.WriteLine($"Gas Tank Capacity: {myCar.GasTankCapacity}");
            //Console.WriteLine($"Year: {myCar.Year}");


            Car jamesCar = new Car();
            jamesCar.Color = "Red";
            jamesCar.CarType = "Sedan";
            jamesCar.Make = "Ford";
            jamesCar.Model = "Fusion";
            jamesCar.GasTankCapacity = 15;
            jamesCar.Year = 2012;
            jamesCar.IsRunning = false;
            jamesCar.Drive(350);
            Console.WriteLine("Data for the second car object");
            Console.WriteLine(jamesCar);
            //Console.WriteLine($"Color: {jamesCar.Color}");
            //Console.WriteLine($"Car Type: {jamesCar.CarType}");
            //Console.WriteLine($"Make: {jamesCar.Make}");
            //Console.WriteLine($"Model: {jamesCar.Model}");
            //Console.WriteLine($"Gas Tank Capacity: {jamesCar.GasTankCapacity}");
            //Console.WriteLine($"Year: {jamesCar.Year}");

            Car conorCar = new Car(2014, "Grey", 12, "Ford", "Focus", "Sedan");
            //conorCar.Color = "Grey";
            //conorCar.CarType = "Sedan";
            //conorCar.Make = "Ford";
            //conorCar.Model = "Focus";
            //conorCar.GasTankCapacity = 12;
            //conorCar.Year = 2014;
            //conorCar.IsRunning = false;
            conorCar.Drive(300);
            Console.WriteLine("Data for the third car object");
            Console.WriteLine(conorCar);
            //Console.WriteLine($"Color: {conorCar.Color}");
            //Console.WriteLine($"Car Type: {conorCar.CarType}");
            //Console.WriteLine($"Make: {conorCar.Make}");
            //Console.WriteLine($"Model: {conorCar.Model}");
            //Console.WriteLine($"Gas Tank Capacity: {conorCar.GasTankCapacity}");
            //Console.WriteLine($"Year: {conorCar.Year}");

            Car emilyCar = new Car()
            {
                Year = 2008,
                Make = "Nissan",
                Model = "Altima",
                CarType = "Sedan",
                Color = "Red",
                GasTankCapacity = 14.5,
                IsRunning = true
            };*/
        }
    }
}
