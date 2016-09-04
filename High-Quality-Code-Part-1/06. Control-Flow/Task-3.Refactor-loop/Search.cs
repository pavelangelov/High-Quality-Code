namespace Task_3.Refactor_loop
{
    using System;

    public static class Search
    {
        /// <summary>
        /// Search passed value in given array. If value is found pring "Value Found!" in Console, else print "Value not found!".
        /// </summary>
        /// <param name="numbers">Array where to search.</param>
        /// <param name="expectedValue">Searched value.</param>
        public static void ValueInArray(int[] numbers, int expectedValue)
        {
            bool isFound = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == expectedValue)
                {
                    isFound = true;
                }
            }

            if (isFound)
            {
                Console.WriteLine("Value Found!");
            }
            else
            {
                Console.WriteLine("Value not found!");
            }
        }
    }
}
