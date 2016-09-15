using System;

namespace Exceptions_Homework.Utils
{
    internal class Validator
    {
        /// <summary>
        /// Check if passed number is less than zero. If it`s true throws ArgumentException.
        /// </summary>
        /// <param name="number">Number to check.</param>
        /// <param name="message">Message to show in trowed exception.</param>
        /// <exception cref="ArgumentException"/>
        internal static void CheckIfNumberIsLessThanZero(int number, string message = null)
        {
            if(number < 0)
            {
                throw new ArgumentException(message);
            }
        }

        /// <summary>
        /// Check if number is between passed minimum and maximum value. If the number is not in this range throws ArgumentOutOfRangeException.
        /// </summary>
        /// <param name="numberToCheck">Number to check.</param>
        /// <param name="maxValue">Maximum value.</param>
        /// <param name="minValue">Minimum value(if not passed, default is 0).</param>
        /// <param name="message">Message to show in trowed exception.</param>
        /// <exception cref="ArgumentOutOfRangeException"/>
        internal static void CheckIfNumberIsInRange(int numberToCheck, int maxValue, int minValue = 0, string message = null)
        {
            if (numberToCheck < minValue || maxValue < numberToCheck)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }

        /// <summary>
        /// Check if passed number is greater than another number. If it isn`t greater throws ArgumentException.
        /// </summary>
        /// <param name="numberToCheck">Number to check.</param>
        /// <param name="anotherNumber">A number to compare.</param>
        /// <param name="message">Message to show in trowed exception.</param>
        /// <exception cref="ArgumentException"/>
        internal static void CheckIfNumberIsEqualOrGreaterThanOtherNumber(int numberToCheck, int anotherNumber, string message = null)
        {
            if (numberToCheck <= anotherNumber)
            {
                throw new ArgumentException(message);
            }
        }

        /// <summary>
        /// Check if passed string is null, empty ot contains only white-spaces. If it`s true, throw ArgumentException.
        /// </summary>
        /// <param name="str">String to check.</param>
        /// <param name="message">Message to show in throwed exception.</param>
        /// <exception cref="ArgumentException"/>
        internal static void CheckStringForNullOrEmpty(string str, string message = null)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException(message);
            }
        }

        /// <summary>
        /// Checks if passed parameter is null.
        /// </summary>
        /// <param name="obj">Object to check.</param>
        /// <param name="message">Message to show if throwed exception.</param>
        /// <exception cref="NullReferenceException"/>
        internal static void CheckForNull(object obj, string message = null)
        {
            if (obj == null)
            {
                throw new NullReferenceException(message)
            }
        }
    }
}
