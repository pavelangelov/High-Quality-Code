﻿using Validation;

namespace Abstraction
{
    public class Rectangle : Figure
    {
        private double width;
        private double height;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="width">Rectangle`s width.</param>
        /// <param name="height">Rectangle`s height.</param>
        public Rectangle(double width, double height)
            : base()
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets or sets Rectangle`s width.
        /// </summary>
        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                Validator.CheckNumberIsLessOrEqualToZero(value, "width", "Width must be greater than 0!");

                this.width = value;
            }
        }

        /// <summary>
        /// Gets or sets Rectangle`s height.
        /// </summary>
        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                Validator.CheckNumberIsLessOrEqualToZero(value, "height", "Height must be greater than 0!");

                this.height = value;
            }
        }

        /// <summary>
        /// Returns rectangle`s perimeter.
        /// </summary>
        /// <returns></returns>
        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);

            return perimeter;
        }

        /// <summary>
        /// Returns rectangle`s surface.
        /// </summary>
        /// <returns></returns>
        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;

            return surface;
        }
    }
}
