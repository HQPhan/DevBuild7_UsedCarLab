using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    class UsedCar : Car
    { 
        public double Mileage { get; set; }
        public UsedCar(string Make, string Model, int Year, decimal Price, double Mileage) : base(Make, Model, Year, Price)
        {
            this.Mileage = Mileage;
        }

        public UsedCar()
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
            this.Mileage = Mileage;
        }
    public override string ToString()
        {
            string output = base.ToString();
            output += $"Mileage: {Mileage}\t".PadRight(10);
            return output;     
        }

    }
}
