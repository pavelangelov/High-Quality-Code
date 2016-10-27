using Composite_Pattern.Contracts;
using Composite_Pattern.Models;

namespace Composite_Pattern
{
    public class Startup
    {
        public static void Main()
        {
            // Single ICleaner instance
            var person = new Person();

            // Composite ICleaner instance. Can contain many single ICleaner instances.
            var cleanerCompany = new CleaningCompany();

            person.Clean();

            cleanerCompany.AddRange(new ICleaner[]
            {
                new Person(),
                new Person(),
                new Person()
            });

            cleanerCompany.Clean();
        }
    }
}
