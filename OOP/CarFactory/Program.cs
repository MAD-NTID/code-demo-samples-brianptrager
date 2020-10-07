using System;

namespace CarFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //I want to create a car object
            Car myCar = new Car();

            myCar.Color = "Red";
            myCar.CarType = "SUV";
            myCar.Make = "Ford";
            myCar.Model = "Explorer";
            myCar.GasTankCapacity = 18;
            myCar.Year = 2018;
            myCar.IsRunning = true;
            myCar.Drive();
            Console.WriteLine("Data for the first car object");
            Console.WriteLine($"Color: {myCar.Color}");
            Console.WriteLine($"Car Type: {myCar.CarType}");
            Console.WriteLine($"Make: {myCar.Make}");
            Console.WriteLine($"Model: {myCar.Model}");
            Console.WriteLine($"Gas Tank Capacity: {myCar.GasTankCapacity}");
            Console.WriteLine($"Year: {myCar.Year}");


            Car jamesCar = new Car();
            jamesCar.Color = "Red";
            jamesCar.CarType = "Sedan";
            jamesCar.Make = "Ford";
            jamesCar.Model = "Fusion";
            jamesCar.GasTankCapacity = 15;
            jamesCar.Year = 2012;
            jamesCar.IsRunning = false;
            jamesCar.Drive();
            Console.WriteLine("Data for the second car object");
            Console.WriteLine($"Color: {jamesCar.Color}");
            Console.WriteLine($"Car Type: {jamesCar.CarType}");
            Console.WriteLine($"Make: {jamesCar.Make}");
            Console.WriteLine($"Model: {jamesCar.Model}");
            Console.WriteLine($"Gas Tank Capacity: {jamesCar.GasTankCapacity}");
            Console.WriteLine($"Year: {jamesCar.Year}");

            Car conorCar = new Car();
            conorCar.Color = "Grey";
            conorCar.CarType = "Sedan";
            conorCar.Make = "Ford";
            conorCar.Model = "Focus";
            conorCar.GasTankCapacity = 12;
            conorCar.Year = 2014;
            conorCar.IsRunning = false;
            conorCar.Drive();
            Console.WriteLine("Data for the first car object");
            Console.WriteLine($"Color: {conorCar.Color}");
            Console.WriteLine($"Car Type: {conorCar.CarType}");
            Console.WriteLine($"Make: {conorCar.Make}");
            Console.WriteLine($"Model: {conorCar.Model}");
            Console.WriteLine($"Gas Tank Capacity: {conorCar.GasTankCapacity}");
            Console.WriteLine($"Year: {conorCar.Year}");


        }
    }
}
