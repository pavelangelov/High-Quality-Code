using Singleton.Contracts;
using Singleton.Models;

namespace Singleton
{
    public class Startup
    {

        public static void Main()
        {
            var webApp = WebApplication.GetInstance();

            var products = new IProduct[]
            {
                new Laptop("Lenovo", "A300", new string[] {"i7", "8GB DDR 3"}),
                new Fridge("Ariston", "A2121", null),
                new DvdPlayer("Samsung", "SG-21", new string[] {"Blu-ray", "6.1"})
            };

            foreach (var item in products)
            {
                webApp.AddProduct(item);
            }
        }
    }
}
