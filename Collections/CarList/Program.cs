using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace CarList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();

            carList.Add(new Car() { Year = 2020, Make = "Honda", Model = "Civic" });
            carList.Add(new Car() { Year = 2016, Make = "Ford", Model = "Mustang" });
            carList.Add(new Car() { Year = 2014, Make = "Ford", Model = "Focus" });

            foreach(Car c in carList)
            {
                Console.WriteLine(c);
            }

            //Insert new car in the list at position 1
            carList.Insert(1, new Car() { Make = "Nissan", Model = "Sentra", Year = 2013 });
            Console.WriteLine("=========AFTER INSERTING A NEW CAR=========");
            foreach (Car c in carList)
            {
                Console.WriteLine(c);
            }

            carList.RemoveAt(2);
          
            Console.WriteLine("=========AFTER REMOVING A CAR BY INDEX=========");
            foreach (Car c in carList)
            {
                Console.WriteLine(c);
            }
            //parts.Remove(new Part() { PartId = 1534, PartName = "cogs" });
            //Console.WriteLine(carList.Remove(new Car() { Make = "Ford", Year = 2014, Model = "Focus" }));
            Console.WriteLine("=========AFTER REMOVING A CAR BY VALUE=========");
            for(int i = 0; i < carList.Count; i++)
            {
                if (carList[i].Make == "Nissan")
                    carList.RemoveAt(i);
                Console.WriteLine(carList[i]);
            }

            CarComparer cc = new CarComparer();

            carList.Sort(cc);
            Console.WriteLine("=========AFTER SORTING THE CAR LIST=========");
            foreach (Car c in carList)
            {
                Console.WriteLine(c);
            }


            carList.Reverse();
            Console.WriteLine("=========AFTER REVERSING THE CAR LIST=========");
            foreach (Car c in carList)
            {
                Console.WriteLine(c);
            }
        }//End Main
    }

    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return String.Format($"Year: {this.Year}\nMake: {this.Make}\nModel: {this.Model}\n");
        }
    }

    class CarComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.Year.CompareTo(y.Year);
        }
    }
}
