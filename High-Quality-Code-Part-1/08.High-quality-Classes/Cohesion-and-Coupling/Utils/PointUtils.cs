using System;

namespace Cohesion_and_Coupling.Utils
{
    public static class PointUtils
    {
        /// <summary>
        /// Calculates distance between two points in 2D space.
        /// </summary>
        /// <param name="first">First point.</param>
        /// <param name="second">Second point.</param>
        /// <returns>Returns double.</returns>
        public static double CalcDistance2D(Point3D first, Point3D second)
        {
            double distanceX = (second.X - first.X) * (second.X - first.X);
            double distanceY = (second.Y - first.Y) * (second.Y - first.Y);

            double distance = Math.Sqrt(distanceX + distanceY);

            return distance;
        }

        /// <summary>
        /// Calculates distance between two points in 3D space.
        /// </summary>
        /// <param name="first">First point.</param>
        /// <param name="second">Second point.</param>
        /// <returns>Returns double.</returns>
        public static double CalcDistance3D(Point3D first, Point3D second)
        {
            double distance = first.DistanceTo(second);

            return distance;
        }
    }
}
