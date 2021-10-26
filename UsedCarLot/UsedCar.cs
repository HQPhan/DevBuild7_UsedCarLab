using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    class UsedCar:Car
    { 
        public double Mileage { get; set; }
        public UsedCar(string Make, string Model, int Year, decimal Price, double Mileage) : base(Make, Model, Year, Price)
        {
            this.Mileage = Mileage;
        }
        //public UsedCar()
        //{
        //    Console.WriteLine("Welcome");
        //}

    public override string ToString()
        {
                string output = $"{Make}".PadRight(10);
                output += $"{Model}".PadRight(10);
                output += $"{Year}".PadRight(10);
                output += $"{Price}".PadRight(10);
                output += $"(Used) {Mileage} miles".PadRight(10);
                return output;      
        }

    }
}
