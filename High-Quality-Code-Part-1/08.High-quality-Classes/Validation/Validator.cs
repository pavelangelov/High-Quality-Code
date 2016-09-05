using System;

namespace Validation
{
    public static class Validator
    {
        public static void CheckNumberIsLessOrEqualToZero(double side, string paramName, string message = null)
        {
            if (side <= 0)
            {
                throw new ArgumentException(message, paramName);
            }
        }

        public static void CheckFileNameForFileExtension(string fileName, string message = null)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                throw new ArgumentException(message);
            }
        }

        public static void CheckForNull(object obj, string paramName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        public static void CheckForNullOrEmpty(string value, string paramName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(paramName);
            }
        }

        public static void CheckStringLength(string value, int maxLength, int minLength = 0, string paramName = null)
        {
            if (value.Length < minLength || maxLength < value.Length)
            {
                throw new ArgumentException(paramName);
            }
        }
    }
}
