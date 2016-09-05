using System;

namespace Abstraction
{
    abstract class Figure
    {
        protected Figure()
        {
        }
        
        public abstract double CalcPerimeter();

        public abstract double CalcSurface();
    }
}
