using Abstract_Factory.Contracts;

namespace Abstract_Factory.Models
{
    public class FordCarFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            var brand = "Ford";
            var model = "Mustang";
            var extras = new string[] { "Nitros" };

            return new Car(brand, model, extras);
        }
    }
}
