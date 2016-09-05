using System;
using System.Collections.Generic;

namespace Abstraction
{
    public class FiguresExample
    {
        /// <summary>
        /// Start the program.
        /// </summary>
        public static void Main()
        {
            var figures = new Figure[]
            {
                new Circle(5),
                new Rectangle(2, 3),
                new Circle(2.4),
                new Rectangle(2.2, 3.3),
            };

            foreach (var figure in figures)
            {
                var perimeter = figure.CalcPerimeter();
                var surface = figure.CalcSurface();
                var figureName = figure.GetType().Name;

                Console.WriteLine($"I am a {figureName}. My perimeter is {perimeter.ToString("f2")}. My surface is {surface.ToString("f2")}.");
            }

            Console.WriteLine();

            // Next lines checks for exceptions if passed parameters are incorect.
            var throwedExceptions = new List<string>();
            var invalidRadius = 0;
            var invalidHeight = -1;

            try
            {
                new Circle(invalidRadius);
            }
            catch (ArgumentException ex)
            {
                throwedExceptions.Add(ex.Message);
            }

            for (int i = 0; i < 2; i++)
            {
                try
                {
                    GetRectangle(i, invalidHeight);
                }
                catch (ArgumentException ex)
                {
                    throwedExceptions.Add(ex.Message);
                }
            }

            foreach (var message in throwedExceptions)
            {
                Console.WriteLine(message);
                Console.WriteLine();
            }
        }

        private static Figure GetRectangle(double width, double height)
        {
            return new Rectangle(width, height);
        }
    }
}
