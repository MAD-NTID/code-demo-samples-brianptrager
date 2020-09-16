using System;

/*
 * Name: Professor Brian Trager
 * Date: 9/16/2020
 * Course: Programming Fundamentals I: Mobile Domain
 * Purpose: Build a robust ordering system for wings!
 * Caveat: The wings need more sauce!
 */

namespace WingsHeaven
{
    class Program
    {
        static void Main(string[] args)
        {
            const double BONELESS_PRICE = 7.99;
            const double TRADITIONAL_PRICE = 9.99;
            const double COMBO_DISCOUNT = .18; //18%
            const double COMBO_PRICE = (BONELESS_PRICE + TRADITIONAL_PRICE) - ((BONELESS_PRICE + TRADITIONAL_PRICE) * COMBO_DISCOUNT);
            const double BUFFALO_SAUCE_PRICE = 0.29;
            const double MILD_SAUCE_PRICE = 0.39;
            const double BBQ_SAUCE_PRICE = 0.99;
            const double WAFFLE_FRIES_PRICE = 3.49;
            const double ONION_RINGS_PRICE = 2.49;
            const double COMBO_SIDES_PRICE = WAFFLE_FRIES_PRICE + ONION_RINGS_PRICE;
            const double TAX_RATE = 0.08;

            string wingsType = "";
            string sauceType = "";
            string sides = "";
            
            double totalPrice = 0;
            double grandTotalPrice = 0;

            //Console.WriteLine(COMBO_PRICE);
            string wingsMenu = $"Enter the kind of wings [b-boneless] {BONELESS_PRICE:C}" + 
                $", [t - traditional] {TRADITIONAL_PRICE:C}, [c - combo] {COMBO_PRICE:C}: ";

            string sauceMenu = $"\n1. Buffalo Sauce ({BUFFALO_SAUCE_PRICE:C})\n2. Mild Sauce ({MILD_SAUCE_PRICE:C})\n" +
                $"3. BBQ Sauce ({BBQ_SAUCE_PRICE:C})\n4. Plain (no cost)\n\n" +
                $"Select one of the preferred sauces: ";

            string sidesMenu = $"\n1. Waffle Fries ({WAFFLE_FRIES_PRICE:C})\n2. Onion Rings ({ONION_RINGS_PRICE:C})\n" +
                $"3. Both sides ({COMBO_SIDES_PRICE:C})\n4. None\n\n" +
                $"Select one of the sides: ";

            Console.Write(wingsMenu);
            string input = Console.ReadLine();

            switch (input)
            {

                case "b": 
                case "t": 
                case "c": wingsType = input;
                    break;

                default: Console.WriteLine("Invalid input...exiting program");
                    Environment.Exit(0);
                    break;
            }

            //==================SAUCE MENU=====================================
            Console.Write(sauceMenu);
            input = Console.ReadLine();

            switch (input)
            {
                case "1": sauceType = "buffalo";  //totalPrice += BUFFALO_SAUCE_PRICE;
                    break;

                case "2":
                    sauceType = "mild";  //totalPrice += MILD_SAUCE_PRICE;
                    break;

                case "3":
                    sauceType = "bbq";  //totalPrice += BBQ_SAUCE_PRICE;
                    break;
                case "4":
                    break;

                default:
                    Console.WriteLine("Invalid input...exiting program");
                    Environment.Exit(0);
                    break;
            }

            //==================SIDES MENU=====================================
            Console.Write(sidesMenu);
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    sides = "waffle";  //totalPrice += BUFFALO_SAUCE_PRICE;
                    break;

                case "2":
                    sides = "onion";  //totalPrice += MILD_SAUCE_PRICE;
                    break;

                case "3":
                    sides = "combo";   //totalPrice += BBQ_SAUCE_PRICE;
                    break;
                case "4":
                    break;

                default:
                    Console.WriteLine("Invalid input...exiting program");
                    Environment.Exit(0);
                    break;
            }

            Console.WriteLine("Wings Heaven\n");

            if (wingsType == "b")
            {
                totalPrice += BONELESS_PRICE;
                Console.WriteLine($"Boneless Wings - {BONELESS_PRICE:C}");
            }
            else if (wingsType == "t")
            {
                totalPrice += TRADITIONAL_PRICE;
                Console.WriteLine($"Traditional Wings - {TRADITIONAL_PRICE:C}");
            }
            else if (wingsType == "c")
            {
                totalPrice += COMBO_PRICE;
                Console.WriteLine($"Combo Wings - {COMBO_PRICE:C}");
            }

            if(sauceType == "buffalo")
            {
                totalPrice += BUFFALO_SAUCE_PRICE;
                Console.WriteLine("Buffalo Sauce");
            }
            else if (sauceType == "mild")
            {
                totalPrice += MILD_SAUCE_PRICE;
                Console.WriteLine("Mild Sauce");
            }
            else if (sauceType == "bbq")
            {
                totalPrice += BBQ_SAUCE_PRICE;
                Console.WriteLine("BBQ Sauce");
            }
            else
            {
                Console.WriteLine("No sauce");
            }

            if (sides == "waffle")
            {
                totalPrice += WAFFLE_FRIES_PRICE;
                Console.WriteLine($"Waffle Fries - {WAFFLE_FRIES_PRICE:C}");
            }
            else if(sides == "onion")
            {
                totalPrice += ONION_RINGS_PRICE;
                Console.WriteLine($"Onion Rings - {ONION_RINGS_PRICE:C}");
            }
            else if (sides == "combo")
            {
                totalPrice += COMBO_SIDES_PRICE;
                Console.WriteLine($"Combo Sides - {COMBO_SIDES_PRICE:C}");
            }
            else
            {
                Console.WriteLine("No side");
            }

            Console.WriteLine($"\nTotal: {totalPrice:C}");
            Console.WriteLine($"Tax: {(totalPrice * TAX_RATE):C}");
            Console.WriteLine($"Total: {(totalPrice + (totalPrice * TAX_RATE)):C}");
        }
    }
}
