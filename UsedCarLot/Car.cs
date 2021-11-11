using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UsedCarLot
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }


        //Constructor with four properties
        public Car(string Make, string Model, int Year, decimal Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }

        public Car()
        {
            Make = "Ford";
            Model = "Escape";
            Year = 2001;
            Price = 3500;
        }

        public override string ToString()
        {
                string output = $"Make: {Make}\t".PadRight(10);
                output += $"Model: {Model}\t".PadRight(10);
                output += $"Year: {Year}\t".PadRight(10);
                output += $"Price: {Price}\t".PadRight(10);
                return output;
        }

    }

    
}
