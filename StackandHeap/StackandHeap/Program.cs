using System;

namespace StackandHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 4;
            CalcDogAge(ref age);

            Console.WriteLine(age);
           // string name = "Jane Doe";

            //Person p1 = new Person() { Age = age, Name = name };
            //Person p2 = new Person() { Age = 23, Name = "John Doe" };

            //Console.WriteLine(p1.GetHashCode());
            //Console.WriteLine(p2.GetHashCode());

            //p2 = p1;
            //Console.WriteLine(p2.GetHashCode());
        }

        //public static int DoResult(int pValue)
        //{
        //    int aValue = 5;
        //    aValue = aValue * pValue;
        //    return aValue;
        //}

        public static void CalcDogAge(ref int age)
        {
            int dogAgeFactor = 7;
            age = age * dogAgeFactor;
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
