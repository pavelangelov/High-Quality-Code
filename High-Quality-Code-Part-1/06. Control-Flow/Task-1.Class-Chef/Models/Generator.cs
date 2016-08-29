namespace Task_1.Class_Chef.Models
{
    using System;

    public static class Generator
    {
        public static double GenerateRandomWeight(int maxValue)
        {
            var random = new Random();

            return random.NextDouble() * maxValue;
        }
    }
}
