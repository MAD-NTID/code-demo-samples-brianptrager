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

        public void Drive()
        {
            if(IsRunning)
            {
                Console.WriteLine("Car is now in drive mode.");
            }
            else
            {
                Console.WriteLine("Cannot shift into drive mode, car is not running");
            }
        }
    }
}
