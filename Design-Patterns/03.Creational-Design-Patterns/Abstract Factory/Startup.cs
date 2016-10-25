using System;

using Abstract_Factory.Contracts;
using Abstract_Factory.Models;

namespace Abstract_Factory
{
    public class Startup
    {
        public static void Main()
        {
            var audiFactory = new AudiCarFactory();
            var forFactory = new FordCarFactory();

            var cars = new ICar[]
            {
                audiFactory.CreateCar(),
                forFactory.CreateCar()
            };

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
