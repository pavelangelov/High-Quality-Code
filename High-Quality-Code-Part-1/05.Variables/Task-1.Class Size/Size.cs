namespace Task_1.Class_Size
{
    using System;

    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.height = value;
            }
        }

        /// <summary>
        /// Return new Size with rotated width and height, by passed angle.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static Size GetRotatedSize(Size size, double angle)
        {
            var rotatedWidth = GetRotateWidth(size, angle);
            var rotatedHeight = GetRotateHeight(size, angle);

            return new Size(rotatedWidth, rotatedHeight);
        }

        private static double GetRotateWidth(Size size, double angle)
        {
            return Math.Abs(Math.Cos(angle)) * size.width + Math.Abs(Math.Sin(angle)) * size.height;
        }

        private static double GetRotateHeight(Size size, double angle)
        {
            return Math.Abs(Math.Sin(angle)) * size.width + Math.Abs(Math.Cos(angle)) * size.height;
        }
    }
}
