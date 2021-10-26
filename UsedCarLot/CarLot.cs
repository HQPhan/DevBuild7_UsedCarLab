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

            Cars.Add(new Car("Add"));
            Cars.Add(new Car("Quit"));

        }
        public Car PickCar(int index)
        {
            Car c = Cars[index - 1];
            return c;
        }
        public void PrintInventory()
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {Cars[i]}");
            }
        }
        public void userBuy(string buy)
        {
            if (buy == "y")
            {
                Console.WriteLine("Excellent choice! Our finance team will be in touch shortly");
            }
            else if (buy == "n")
            {
                Console.WriteLine("Would you like to keep shopping");
            }
        }

        public static Nullable<int> Dig()
        {
            return null;
        }

        //Nee t



    }
}
