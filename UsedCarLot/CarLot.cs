using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    class CarLot
    {
        public List<Car> Cars { get; set; } = new List<Car>();
        public CarLot()
        {
            Cars.Add(new UsedCar("Ford", "Escape", 2015, 3000, 115000.6));
            Cars.Add(new UsedCar("Cadillac", "CTS", 2009, 4500, 137000.3));
            Cars.Add(new UsedCar("Dodge", "Durango", 2017, 7500, 85000.0));

            Cars.Add(new Car("Jeep", "Wrangler", 2022, 40930));
            Cars.Add(new Car("Chrysler", "300", 2021, 31540));
            Cars.Add(new Car("Mercedes", "GLC", 2023, 51650));
        }

        public string PrintInventory()
        {
            string print = "";
            for (int i = 0; i < Cars.Count; i++)
            {
                print += $"{i + 1}: {Cars[i]}\n";
            }
            print += $"{Cars.Count + 1}: Sell\n";
            print += $"{Cars.Count + 2}: Quit\n";
            return print;
        }

        public void SellCar()
        {           
            string userNewOrUsed = GetInput("Enter [1]New or [2]Used: ");
            if (userNewOrUsed == "1" || userNewOrUsed == "2")
            {                
                string make = GetInput("Enter Make: ");
                string model = GetInput("Enter Model: ");
                int year = 0;
                decimal price = 0;
                bool badFormat = true;
                while (badFormat)
                {
                    try
                    {
                        year = int.Parse(GetInput("Enter Year: "));
                        badFormat = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Try Again!");
                        badFormat = true;
                    }                    
                }

                badFormat = true;
                while (badFormat)
                {
                    try
                    {
                        price = decimal.Parse(GetInput("Enter Price: "));
                        badFormat = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Try Again!");
                        badFormat = true;
                    }
                }

                switch (userNewOrUsed)
                {
                    case "1":
                        Cars.Add(new Car(make, model, year, price));
                        break;
                    case "2":
                        double mileage = double.Parse(GetInput("Mileage: "));
                        Cars.Add(new UsedCar(make, model, year, price, mileage));
                        break;
                }
            }               
            else
            {
                Console.WriteLine("Invalid Entry! Please enter 1 or 2!");
                SellCar();
            }
        }

        public void BuyCar(int userNum)
        {                   
            Console.WriteLine(Cars[userNum - 1]);
            string userBuy = GetInput("Would you like to buy this car? (y/n): ");
            if (userBuy == "y")
            {
                Cars.RemoveAt(userNum - 1);
                Console.WriteLine("Our Finance Team will be in contact shortly!");
            }
            else if (userBuy == "n")
            {
            }
            else
            {
                Console.WriteLine("Invalid entry. Please enter (y/n)");
                BuyCar(userNum);
            }           
        }

        public int SelectMenu()
        {
            try
            {
                int userSelectMenu = int.Parse(GetInput($"Please select from menu. Select from [1] to [{Cars.Count + 2}]: ").Trim());
                if (userSelectMenu >= 1 && userSelectMenu <= Cars.Count + 2)
                {
                    return userSelectMenu;
                }
                else
                {
                    Console.WriteLine($"Invalid entry. Please enter number between 1 to {Cars.Count + 2}");
                    return SelectMenu();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Try Again!");
                return SelectMenu();
            }
        }

        public string GetInput(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine().Trim();
            return input;
        }

        public bool UserContinue()
        {
            string userInput = GetInput("Would you like to continue? (y/n): ").ToLower().Trim();
            if (userInput == "y" || userInput == "yes")
            {
                return true;
            }
            else if(userInput == "n" || userInput == "no")
            {
                Console.WriteLine("Thank you for shopping at Max's New and Used Cars! Come again!");
                return false;
            }
            else
            {
                Console.WriteLine("Invalid entry. Please enter (y/n)!");
                return UserContinue();
            }
        }
    }
}
