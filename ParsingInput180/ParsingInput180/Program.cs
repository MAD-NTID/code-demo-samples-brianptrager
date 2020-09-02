using System;

namespace ParsingInput180
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUM_OF_STUDENTS = 5;
            const double PI = 3.14159;
            const string FIRST_MESSAGE = "Good morning";

            string numOfDaysInThisCourse = "42";

            //int actualNumber = int.Parse("42");
            int actualNumber = int.Parse(numOfDaysInThisCourse);

            Console.WriteLine("Enter a number: ");
            //string aNumber = Console.ReadLine();
            int aNumber = int.Parse(Console.ReadLine());

            Console.Write("What is your GPA? ");
            double gpa = double.Parse(Console.ReadLine());

            Console.WriteLine(aNumber + aNumber);
            Console.WriteLine(actualNumber + actualNumber);
            Console.WriteLine("Your improved GPA is {0}", gpa + 0.25);
            Console.ReadLine();

        }
    }
}
