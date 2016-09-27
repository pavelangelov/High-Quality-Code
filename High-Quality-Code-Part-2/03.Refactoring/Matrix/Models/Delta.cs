using MatrixHomework.Contracts;

namespace MatrixHomework.Models
{
    public class Delta : IDelta
    {
        /// <summary>
        /// Initializes a new instance of tha class <see cref="Delta"/>.
        /// </summary>
        /// 
        public Delta()
        {
        }

        /// <summary>
        /// Gets ot sets Delta-X possition.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets oor sets Delta-Y possition.
        /// </summary>
        public int Y { get; set; }
    }
}
