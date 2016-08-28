namespace Task_2.Method_PrintStatistics
{
    using System;

    public static class Print
    {
        public static void PrintStatistics(double[] arr, int count)
        {
            double maxValue = double.MinValue;
            double minValue = double.MaxValue;
            double sum = 0;
            for (int i = 0; i < count; i++)
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

            double average = sum / count;

            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);
            Console.WriteLine(average);
        }
    }
}
