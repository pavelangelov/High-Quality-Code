using System;

namespace Abstraction
{
    class FiguresExample
    {
        static void Main()
        {
            var figures = new Figure[]
            {
                new Circle(5),
                new Rectangle(2, 3),
                new Circle(2.4),
                new Rectangle(2.2, 3.3)
            };

            foreach (var figure in figures)
            {
                var perimeter = figure.CalcPerimeter();
                var surface = figure.CalcSurface();
                var figureName = figure.GetType().Name;

                Console.WriteLine($"I am a {figureName}. My perimeter is {perimeter.ToString("f2")}. My surface is {surface.ToString("f2")}.");
            }

            //Figure circle = new Circle(5);
            //Console.WriteLine("I am a circle. " +
            //    "My perimeter is {0:f2}. My surface is {1:f2}.",
            //    circle.CalcPerimeter(), circle.CalcSurface());
            //Figure rect = new Rectangle(2, 3);
            //Console.WriteLine("I am a rectangle. " +
            //    "My perimeter is {0:f2}. My surface is {1:f2}.",
            //    rect.CalcPerimeter(), rect.CalcSurface());
        }
    }
}
