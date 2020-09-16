using System;

namespace DebuggingCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //int var1 = 20;
            //int var2 = 0;

            //if (var1 >= 10)
            //{

            //    var2 = 30;
            //}

            //Console.WriteLine(var2);

            //==================================================
            //int num1;

            //Console.Write("Enter a number: ");

            //if (int.TryParse(Console.ReadLine(), out num1))
            //    Console.WriteLine("This is a valid number.");

            /*==================================================


            int num1;

            Console.Write("Enter a positive number: ");

            if (int.TryParse(Console.ReadLine(), out num1))
                if (num1 >= 0)
                    Console.WriteLine("This is a positive number.");


            ======================================================
            int num1, num2;

            num1=10;
            num2=10;

            if(num1 == 10 && 10 == num2)
            {
	            Console.WriteLine("Both numbers are 10.");
            }

            ========================================================= 

            int num1, num2;

            num1 = 10;
            num2 = 20;

            if (num1 >= 10 || num2 <= 10)
            {
                Console.WriteLine("Either conditions are met.");
            }

            ========================================================== 

            int num1, num2;

            num1 = 10;
            num2 = 20;

            if ((num1 >= 10) || (num2 <= 10))
            {
                Console.WriteLine("Either conditions are met.");
            }

            ===============================================================

            int var1 = 15;
            int var2 = 30;

            if (var1 > 10)
            {
                if (var2 < 30)
                {
                    Console.WriteLine("Both conditions are met.");
                }
                else
                {
                    Console.WriteLine("var 2 is not less than 30.");
                }
            }
            else
                Console.WriteLine("var1 is not greater than 10.");

            ===========================================================*/

            string num1;

            Console.Write("Enter a number between 1 - 3: ");
            num1 = Console.ReadLine();

            switch (num1)
            {
                case "1":
                    Console.WriteLine("It is 1!");
                    break;
                case "2":
                    Console.WriteLine("It is 2!");
                    break;
                case "3":
                    Console.WriteLine("It is 3!");
                    break;
            }

        }
    }
}
