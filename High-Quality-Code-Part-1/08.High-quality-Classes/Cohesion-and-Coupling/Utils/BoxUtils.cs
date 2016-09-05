using System;

namespace Cohesion_and_Coupling.Utils
{
    public class BoxUtils
    {

        /// <summary>
        /// Calculates the volume of the box.
        /// </summary>
        /// <param name="box">Box.</param>
        /// <returns>Returns double.</returns>
        public static double CalcVolume(Box box)
        {
            double volume = box.Width * box.Height * box.Depth;

            return volume;
        }

        /// <summary>
        /// Calculates the length of the box`s diagonal.
        /// </summary>
        /// <param name="box">Box.</param>
        /// <returns>Returns double.</returns>
        public static double CalcDiagonalXYZ(Box box)
        {
            double widthSquared = box.Width * box.Width;
            double heightSquared = box.Height * box.Height;
            double depthSquared = box.Depth * box.Depth;

            double diagonal = Math.Sqrt(widthSquared + heightSquared + depthSquared);

            return diagonal;
        }

        /// <summary>
        /// Calculates the diagonal of one side of the box.
        /// </summary>
        /// <param name="firstSide">One of the sides of the box.</param>
        /// <param name="secondSide">Other side of the box.</param>
        /// <returns>Returns double.</returns>
        public static double CalculateSideDiagonal(double firstSide, double secondSide)
        {
            double distance = CalculateDistanceBySizes(firstSide, secondSide);

            return distance;
        }

        private static double CalculateDistanceBySizes(double firstSize, double secondSize)
        {
            double firstSizeSquared = firstSize * firstSize;
            double secondSizeSquared = secondSize * secondSize;

            double distance = Math.Sqrt(firstSizeSquared + secondSizeSquared);

            return distance;
        }
    }
}
