using System;
using System.Collections.Generic;

namespace CarList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();

            carList.Add(new Car() { Year = 2020, Make = "Honda", Model = "Civic" });
            carList.Add(new Car() { Year = 2016, Make = "Ford", Model = "Mustang" });


            foreach(Car c in carList)
            {
                Console.WriteLine(c);
            }
        }
    }

    class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return String.Format($"Year: {this.Year}\nMake: {this.Make}\nModel: {this.Model}\n");
        }
    }
}
