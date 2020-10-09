using System;
using System.Collections.Generic;
using System.Text;

namespace CarFactory
{
    class Car
    {
        public int Year { get; set; }
        public string Color { get; set; }
        public int GasTankCapacity { get; set; }
        public string CarType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool IsRunning { get; set; }

        public void Drive(int miles)
        {
            if(IsRunning)
            {
                Console.WriteLine($"Car is now in drive mode. You can drive for approximately {miles} miles.");
            }
            else
            {
                Console.WriteLine("Cannot shift into drive mode, car is not running");
            }
        }

        public Car()
        {
            Year = 1900;
            Make = "Unknown";
            Model = "Unknown";
            GasTankCapacity = 0;
            CarType = "N/A";
            Color = "Black";
            IsRunning = false;
        }

        public Car(int year, string color, int gasTankCapacity, string make, string model, string carType)
        {
            Year = year;
            Color = color;
            GasTankCapacity = gasTankCapacity;
            Make = make;
            Model = model;
            CarType = carType;
            IsRunning = true;
        }

        public override string ToString()
        {
            return String.Format($"Year: {Year}\nMake: {Make}\nModel: {Model}\n" +
                $"Car Type: {CarType}\nColor: {Color}\n" +
                $"Gas Tank Capacity: {GasTankCapacity}");
        }
    }
}
