using System.Collections.Generic;

using Composite_Pattern.Contracts;

namespace Composite_Pattern.Models
{
    public class CleaningCompany : ICleaner
    {
        private ICollection<ICleaner> cleaners;

        public CleaningCompany()
        {
            this.cleaners = new List<ICleaner>();
        }

        public void AddWasher(ICleaner cleaner)
        {
            this.cleaners.Add(cleaner);
        }

        public void AddRange(ICollection<ICleaner> cleaners)
        {
            foreach (var cleaner in cleaners)
            {
                this.cleaners.Add(cleaner);
            }
        }

        public void Clean()
        {
            foreach (var cleaner in cleaners)
            {
                cleaner.Clean();
            }
        }
    }
}
