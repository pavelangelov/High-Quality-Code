using System;

namespace Methods
{
    public static class MathCalculations
    {
        /// <summary>
        /// Calculating triangle`s area by given three sides.
        /// </summary>
        /// <param name="a">First side.</param>
        /// <param name="b">Second side.</param>
        /// <param name="c">Third side.</param>
        /// <returns></returns>
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }
            else if (!AreValidSides(a, b, c))
            {
                throw new ArgumentException("Invalid triangle sides.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }

        private static bool AreValidSides(double firstSide, double secondSide, double thirdSide)
        {
            if (((firstSide + secondSide) > thirdSide) &&
                ((firstSide + thirdSide) > secondSide) &&
                ((secondSide + thirdSide) > firstSide))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Find maximum value in sequence of numbers. The numbers must be in array or listed one by one. 
        /// </summary>
        /// <param name="numbers">Sequence of numbers.</param>
        /// <returns></returns>
        public static int FindMax(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new NullReferenceException("elements");
            }

            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        /// <summary>
        /// Calculate distance between two points.
        /// </summary>
        /// <param name="x1">Frist Point x coordinate.</param>
        /// <param name="y1">Frist Point y coordinate.</param>
        /// <param name="x2">Second Point x coordinate.</param>
        /// <param name="y2">Second Point y coordinate.</param>
        /// <returns></returns>
        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distanceX = (x2 - x1) * (x2 - x1);
            double distanceY = (y2 - y1) * (y2 - y1);
            double distance = Math.Sqrt(distanceX + distanceY);

            return distance;
        }

        public static bool IsHorizontal(double y1, double y2)
        {
            return y1 == y2;
        }

        public static bool IsVertical(double x1, double x2)
        {
            return x1 == x2;
        }
    }
}
