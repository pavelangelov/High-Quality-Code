using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ArrayGenerators
    {
        public static int[] GenerateIntArray(int arrayLength)
        {
            var intArray = new int[arrayLength];
            var random = new Random();
            for (int i = 0; i < arrayLength; i++)
            {
                var randomValue = random.Next(Constants.IntegerMinValue, Constants.IntegerMaxValue);
                intArray[i] = randomValue;
            }

            return intArray;
        }

        public static double[] GenerateDoubleArray(int arrayLength)
        {
            var doubleArray = new double[arrayLength];
            var random = new Random();
            for (int i = 0; i < arrayLength; i++)
            {
                var randomValue = random.NextDouble() * arrayLength;
                doubleArray[i] = randomValue;
            }

            return doubleArray;
        }

        public static string[] GenerateStringArray(int arrayLength)
        {
            var alfabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var stringArray = new string[arrayLength];
            var random = new Random();
            for (int i = 0; i < arrayLength; i++)
            {
                int strLen = random.Next(Constants.MinStringLength, Constants.MaxStringLength);
                string word = "";
                for (int j = 0; j < strLen; j++)
                {
                    int charIndex = random.Next(0, 25);
                    word += alfabet[charIndex];
                }

                stringArray[i] = word;
            }

            return stringArray;
        }
    }
}
