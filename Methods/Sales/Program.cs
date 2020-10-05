using System;
using System.Linq;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "Good morning! ";
            //string s2 = "Good afternoon!";

            //string s3 = String.Concat(s1, s2);

            //Console.WriteLine(s3);

            //char c = s1[0];

            Console.Write("Enter the subtotal: ");
            double subtotal = double.Parse(Console.ReadLine());

            Console.Write("Does your state collect tax? (y/n): ");
            char c = Console.ReadLine().ToUpper()[0];
            if(c == 'Y')
            {
                Console.Write("Enter the sales tax (%): ");
                double salesTax = double.Parse(Console.ReadLine());

                subtotal = CalculateTotal(subtotal, salesTax / 100);
                //Console.WriteLine(CalculateTotal(subtotal, salesTax / 100));
                //CalculateTotal(subtotal, double.Parse(Console.ReadLine()) / 100);
            }
            else
            {
                subtotal = CalculateTotal(subtotal);
            }

            Console.Write($"{subtotal:C}");
        }

        /// <summary>
        /// Calculates the sales tax based on the sales tax amount in percentage format
        /// </summary>
        /// <param name="subTotal">the subtotal of an order</param>
        /// <param name="salesTax">the sales tax percentage in double format, if none given, then default value is 0</param>
        /// <returns>The sum of subtotal and sales tax (if applicable)</returns>
        private static double CalculateTotal(double subTotal, double salesTax = 0)
        {
            return subTotal + (subTotal * salesTax);
        }
    }
}
