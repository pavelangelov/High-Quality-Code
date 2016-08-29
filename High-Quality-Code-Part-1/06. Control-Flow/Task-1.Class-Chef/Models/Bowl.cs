namespace Task_1.Class_Chef.Models
{
    using System;
    using System.Collections.Generic;

    public  class Bowl
    {
        private readonly double capacity;
        private List<Vegetable> vegetables;

        public Bowl()
        {
            this.capacity = 1500;
            this.vegetables = new List<Vegetable>();
        }

        /// <summary>
        /// Returns the capacity in milliliters.
        /// </summary>
        public double Capacity
        {
            get
            {
                return this.capacity;
            }
        }

        public void Add(Vegetable vegetable)
        {
            if (vegetable == null)
            {
                throw new NullReferenceException("vegetable");
            }

            this.vegetables.Add(vegetable);
        }
        
    }
}
