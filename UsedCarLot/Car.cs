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
        public Menu Add { get; set; }


        //Constructor with four properties
        public Car(string Make, string Model, int Year, decimal Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }
        //Empty Constructor
        public Car(Menu Add)
        {
            this.Add = Add;
        }
        public Car()
        {

        }

        public override string ToString()
        {
                string output = $"{Make}".PadRight(10);
                output += $"{Model}".PadRight(10);
                output += $"{Year}".PadRight(10);
                output += $"{Price}".PadRight(10);
                return output;
        }

    }

    
}
