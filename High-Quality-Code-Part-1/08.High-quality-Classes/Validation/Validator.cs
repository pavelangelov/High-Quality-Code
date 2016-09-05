using System;

namespace Validation
{
    public static class Validator
    {
        public static void ValidateCircleRadius(double radius, string message = null)
        {
            if (radius <= 0)
            {
                throw new ArgumentException(message, "radius");
            }
        }

        public static void ValidateRectangleSide(double side, string paramName, string message = null)
        {
            if (side <= 0)
            {
                throw new ArgumentException(message, paramName);
            }
        }
    }
}
