using System;

namespace Cohesion_and_Coupling
{
    public class Point3D
    {
        public static readonly Point3D Center = new Point3D(0, 0, 0);

        /// <summary>
        /// Create new instance of Point3D.
        /// </summary>
        /// <param name="x">Point x-coordinate.</param>
        /// <param name="y">Point y-coordinate.</param>
        /// <param name="z">Point z-coordinate.</param>
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        /// <summary>
        /// Point x-coordinate.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Point y-coordinate.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Point z-coordinate
        /// </summary>
        public double Z { get; set; }

        /// <summary>
        /// Calculates distance between to passed Point.
        /// </summary>
        /// <param name="otherPoint"></param>
        /// <returns>Returns double.</returns>
        public double DistanceTo(Point3D otherPoint)
        {

            double distanceX = (otherPoint.X - this.X) * (otherPoint.X - this.X);
            double distanceY = (otherPoint.Y - this.Y) * (otherPoint.Y - this.Y);
            double distanceZ = (otherPoint.Z - this.Z) * (otherPoint.Z - this.Z);

            double distance = Math.Sqrt(distanceX + distanceY + distanceZ);

            return distance;
        }
    }
}
