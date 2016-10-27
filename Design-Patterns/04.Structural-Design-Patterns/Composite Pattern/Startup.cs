using Composite_Pattern.Contracts;
using Composite_Pattern.Models;

namespace Composite_Pattern
{
    public class Startup
    {
        public static void Main()
        {
            var cleaners = new ICleaner[]
            {
                new Person(),
                new Person(),
                new Person()
            };

            // Single ICleaner instance
            ICleaner person = new Person();

            // Composite ICleaner instance. Can contain many single ICleaner instances.
            ICleaner cleanerCompany = new CleaningCompany(cleaners);

            person.Clean();


            cleanerCompany.Clean();
        }
    }
}
