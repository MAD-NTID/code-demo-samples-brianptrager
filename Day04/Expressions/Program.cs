using System;
/*
 * Name: Brian Trager
Course: NMAD.180 Programming Fundamentals I: Mobile Domain
Date: 8/26/2020
Purpose: Teach expressions, especially mathematical expressions :)
Caveats: There's none, math is good for you!
*/

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Statements
            int costPerCredit = 850; //variable initialization
            int credits = 15;

            int scholarship = 7000;

            credits = 20;
            //Expression
            int subTotal = costPerCredit * credits;

            int netTotal = subTotal - scholarship;

            //Console.WriteLine("Total: {0:C}", costPerCredit * credits);
            Console.WriteLine("Subtotal: {0:C}", subTotal);
            Console.WriteLine("Scholarship Amount: {0:C}", scholarship);
            Console.WriteLine("Net Total: {0:C}", netTotal);
        }
    }
}
