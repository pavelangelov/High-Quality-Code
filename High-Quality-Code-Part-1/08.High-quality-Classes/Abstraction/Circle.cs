using System;

using Validation;

namespace Abstraction
{
    class Circle : Figure
    {
        private double radius;

        /// <summary>
        /// Create new instance of Circle.
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
            :base()
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Circle`s radius.
        /// </summary>
        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                Validator.ValidateCircleRadius(value, "Radius must be greater than 0!");

                this.radius = value;
            }
        }

        /// <summary>
        /// Returns circle`s perimeter.
        /// </summary>
        /// <returns></returns>
        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        /// <summary>
        /// Returns circle`s surface.
        /// </summary>
        /// <returns></returns>
        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
