namespace Task_1.Class_Chef.Models
{
    using Vegetables;

    public static class Store
    {
        private const int MaxCarrotWeight = 250;
        private const int MaxPotatoWeight = 750;

        /// <summary>
        /// Return new Bowl
        /// </summary>
        /// <returns>Return new Bowl</returns>
        public static Bowl GetBowl()
        {
            return new Bowl();
        }

        /// <summary>
        /// Return new Carrot with random generated weight between 0 and 250.
        /// </summary>
        /// <returns>Return new Carrot</returns>
        public static Carrot GetCarrot()
        {
            var carrotWeight = Generator.GenerateRandomWeight(MaxCarrotWeight);

            return new Carrot(carrotWeight);
        }

        /// <summary>
        /// Return new Potato with random generated weight between 0 and 750.
        /// </summary>
        /// <returns>Return new Potato</returns>
        public static Potato GetPotato()
        {
            var potatoWeight = Generator.GenerateRandomWeight(MaxPotatoWeight);

            return new Potato(potatoWeight);
        }
    }
}
