using System;

namespace Abstraction
{
    abstract class Figure
    {
        protected Figure()
        {
        }

        /// <summary>
        /// Returns figure`s perimeter.
        /// </summary>
        /// <returns></returns>
        public abstract double CalcPerimeter();
        
        /// <summary>
        /// Returns figure`s surface.
        /// </summary>
        /// <returns></returns>
        public abstract double CalcSurface();
    }
}
