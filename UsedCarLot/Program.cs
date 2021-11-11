using System;
using System.Collections.Generic;

namespace UsedCarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot cl = new CarLot();
            Console.WriteLine("Welcome to H&R's New & Used Cars!");
          
            bool goOn = true;
            while (goOn)
            {
                Console.WriteLine();
                Console.WriteLine(cl.PrintInventory());                               
                int userNum = cl.SelectMenu();
                
                if (userNum <= cl.Cars.Count)
                {
                    cl.BuyCar(userNum);
                }
                else if (userNum == (cl.Cars.Count + 1))
                {
                    Console.WriteLine("Would you like to sell a new or used car? ");
                    cl.SellCar();
                }
                else if (userNum == (cl.Cars.Count + 2))
                {
                    Console.WriteLine("Thank you for shopping at Max's New and Used Cars! Come again!");
                    break;
                }
                               
                goOn = cl.UserContinue();
            }
        }      
    }
}
