using Singleton.Contracts;

namespace Singleton.Models
{
    public class WebApplication
    {
        private static WebApplication instance = null;

        private WebApplication()
        {
        }

        public static WebApplication GetInstance()
        {
            if (instance == null)
            {
                instance = new WebApplication();
            }

            return instance;
        }

        public void AddProduct(IProduct product)
        {
            // Add product to the web app
        }

        public void RemoveProduct(IProduct product)
        {
            // Remove product from the web app
        }
    }
}
