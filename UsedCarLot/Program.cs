using System;
using System.Collections.Generic;

namespace UsedCarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Max's New & Used Cars!");
            Console.WriteLine();

            CarLot cl = new CarLot();
            cl.PrintInventory();

            Car c = new Car();
            Console.WriteLine(c);

            int buy = int.Parse(GetInput("What car would you like? "));
            Console.WriteLine(cl.PickCar(buy));


            
            
        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }
    }
}
