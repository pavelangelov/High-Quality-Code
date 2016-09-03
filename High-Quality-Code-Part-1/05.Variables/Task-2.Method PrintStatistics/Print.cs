namespace Task_2.Method_PrintStatistics
{
    using System;

    public static class Print
    {
        /// <summary>
        /// Print max, min and average value from passed array. Each value is writed on new line.
        /// </summary>
        /// <param name="arr">The array, where to search for max, min and average value.</param>
        /// <param name="lastIndex">The index of the last elemet from the array, who will be calculated.</param>
        public static void PrintMaxMinAverage(double[] arr, int lastIndex)
        {
            double maxValue = double.MinValue;
            double minValue = double.MaxValue;
            double sum = 0;
            for (int i = 0; i < lastIndex; i++)
            {
                double currentValue = arr[i];
                if (currentValue > maxValue)
                {
                    maxValue = currentValue;
                }

                if (currentValue < minValue)
                {
                    minValue = currentValue;
                }

                sum += currentValue;
            }

            double average = sum / lastIndex;

            Console.WriteLine($"Max: {maxValue}");
            Console.WriteLine($"Min: {minValue}");
            Console.WriteLine($"Average: {average}");
        }
    }
}
