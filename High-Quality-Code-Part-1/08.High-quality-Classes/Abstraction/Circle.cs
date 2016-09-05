﻿using System;

namespace Abstraction
{
    class Circle : Figure
    {
        public Circle(double radius)
            :base()
        {
            this.Radius = radius;
        }

        public double Radius { get; set; }
        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
