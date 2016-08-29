namespace Task_1.Class_Chef.Models
{
    public static class Store
    {
        public static Bowl GetBowl()
        {
            return new Bowl();
        }

        public static Carrot GetCarrot()
        {
            var carrotWeight = Generator.GenerateRandomWeight(250);

            return new Carrot(carrotWeight);
        }

        public static Potato GetPotato()
        {
            var potatoWeight = Generator.GenerateRandomWeight(750);

            return new Potato(potatoWeight);
        }
    }
}
