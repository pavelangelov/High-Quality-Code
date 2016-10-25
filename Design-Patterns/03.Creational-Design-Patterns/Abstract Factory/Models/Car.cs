using System;
using System.Collections.Generic;
using System.Text;

using Abstract_Factory.Contracts;

namespace Abstract_Factory.Models
{
    public class Car : ICar
    {
        public Car(string brand, string model, IEnumerable<string> extras)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = DateTime.Now.Year;
            this.Extras = extras;
        }

        public string Brand { get; set; }

        public IEnumerable<string> Extras { get; set; }

        public string Model { get; set; }

        public int Year { get;}

        public override string ToString()
        {
            var result = new StringBuilder();
            var extrasStr = string.Join(", ", this.Extras);

            result.AppendLine($"{this.Brand}  {this.Model}");
            result.AppendLine($"Year of manufacturer: {this.Year}");
            result.AppendLine($"Extras: \r\n{extrasStr}");

            return result.ToString();
        }
    }
}
