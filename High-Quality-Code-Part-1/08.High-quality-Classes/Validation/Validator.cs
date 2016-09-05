using System;

namespace Validation
{
    public static class Validator
    {
        /// <summary>
        /// If passed number is less or equal to 0 throws ArgumentException.
        /// </summary>
        /// <param name="number">Number to check.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <param name="message">Error message to throw.</param>
        public static void CheckNumberIsLessOrEqualToZero(double number, string paramName, string message = null)
        {
            if (number <= 0)
            {
                throw new ArgumentException(message, paramName);
            }
        }

        /// <summary>
        /// If string doen`t contain file extension in the end, throws ArgumentException.
        /// </summary>
        /// <param name="fileName">The name of the file.</param>
        /// <param name="message">Error message to throw.</param>
        public static void CheckFileNameForFileExtension(string fileName, string message = null)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                throw new ArgumentException(message);
            }
        }

        /// <summary>
        /// If passed parameter is null, throws ArgumentNullException.
        /// </summary>
        /// <param name="obj">Parameter to check.</param>
        /// <param name="paramName">The name of the parameter.</param>
        public static void CheckForNull(object obj, string paramName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        /// <summary>
        /// If passed string is null, empty or consists only of white-space characters, throws ArgumentException.
        /// </summary>
        /// <param name="value">String to check.</param>
        /// <param name="paramName">The name of the parameter.</param>
        public static void CheckForNullOrEmpty(string value, string paramName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(paramName);
            }
        }

        /// <summary>
        /// If passed string length is not in range, throws ArgumentException.
        /// </summary>
        /// <param name="value">String which length to check.</param>
        /// <param name="maxLength">Maximum allowed length of the string.</param>
        /// <param name="minLength">Minimum allowed length of the string.</param>
        /// <param name="paramName">The name of the parameter.</param>
        public static void CheckStringLength(string value, int maxLength, int minLength = 0, string paramName = null)
        {
            if (value.Length < minLength || maxLength < value.Length)
            {
                throw new ArgumentException(paramName);
            }
        }
    }
}
