using System;

namespace Methods
{
    public static class TransformNumber
    {
        /// <summary>
        /// Converts number in the range [0…9] to word.
        /// </summary>
        /// <param name="number">Number to convert to word.</param>
        /// <returns></returns>
        public static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default:
                    throw new ArgumentException("Invalid number!");
            }
        }

        /// <summary>
        /// Format the number by passed format type. Floating - floating format with 2 digits precision, 
        /// Percent - format the number to percent, PadLeft - padding left with 8 positions.
        /// </summary>
        /// <param name="number">The number to format.</param>
        /// <param name="formatType">Format type.</param>
        public static void PrintFormatedNumber(double number, FormatType formatType)
        {
            switch (formatType)
            {
                case FormatType.Floating:
                    Console.WriteLine(FloatingFormat(number));
                    break;
                case FormatType.Percent:
                    Console.WriteLine(PercentFormating(number));
                    break;
                case FormatType.PadLeft:
                    Console.WriteLine(PadRightFormat(number));
                    break;
                default:
                    throw new ArgumentException("Invalid formating parameter!");
            }
        }

        private static string FloatingFormat(double number)
        {
            string formatedNumber = string.Format("{0:f2}", number);

            return formatedNumber;
        }

        private static string PercentFormating(double number)
        {
            string formatedNumber = string.Format("{0:p0}", number);

            return formatedNumber;
        }

        private static string PadRightFormat(double number)
        {
            string formatedNumber = string.Format("{0,8}", number);

            return formatedNumber;
        }
    }
}
