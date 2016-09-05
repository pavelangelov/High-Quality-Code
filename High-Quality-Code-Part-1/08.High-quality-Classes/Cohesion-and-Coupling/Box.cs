using Validation;

namespace Cohesion_and_Coupling
{
    public class Box
    {
        private const string IncorectBoxParameterMessage = "Box {0} must be greater than 0!";

        private double width;
        private double height;
        private double depth;

        /// <summary>
        /// Create new instance of Box.
        /// </summary>
        /// <param name="width">Width of the box.</param>
        /// <param name="height">Height of the box.</param>
        /// <param name="depth">Depth of the box.</param>
        public Box(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        /// <summary>
        /// Width of the box.
        /// </summary>
        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                var errorMsg = string.Format(IncorectBoxParameterMessage, "width");
                Validator.CheckNumberIsLessOrEqualToZero(value, "width", errorMsg);

                this.width = value;
            }
        }

        /// <summary>
        /// Height of the box.
        /// </summary>
        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                var errorMsg = string.Format(IncorectBoxParameterMessage, "width");
                Validator.CheckNumberIsLessOrEqualToZero(value, "height", errorMsg);

                this.height = value;
            }
        }

        /// <summary>
        /// Depth of the box.
        /// </summary>
        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                var errorMsg = string.Format(IncorectBoxParameterMessage, "depth");
                Validator.CheckNumberIsLessOrEqualToZero(value, "depth", errorMsg);

                this.depth = value;
            }
        }
    }
}
