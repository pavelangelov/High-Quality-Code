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
    }
}
