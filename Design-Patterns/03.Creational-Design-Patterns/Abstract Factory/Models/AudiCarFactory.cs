using Abstract_Factory.Contracts;

namespace Abstract_Factory.Models
{
    public class AudiCarFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            var brand = "Audi";
            var model = "R8";
            var extras = new string[] { "Lethear salon", "Clima" };

            return new Car(brand, model, extras);
        }
    }
}
