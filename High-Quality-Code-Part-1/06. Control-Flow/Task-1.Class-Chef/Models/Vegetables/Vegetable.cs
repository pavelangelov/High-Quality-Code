namespace Task_1.Class_Chef.Models.Vegetables
{
    using System;
    using System.Collections.Generic;

    public abstract class Vegetable
    {
        private double weight;
        private bool isCutted = false;
        private List<double> pieces;

        public Vegetable(double weight)
        {
            this.Weight = weight;
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }

            protected set
            {
                this.weight = value;
            }
        }

        public abstract void Peel();

        /// <summary>
        /// Cut the vegetable.
        /// </summary>
        /// <param name="size">The size of every piece.</param>
        public void GetCutted(int size)
        {
            if (!isCutted)
            {
                var vegatebleWeight = this.Weight;
                pieces = new List<double>();
                while (vegatebleWeight > 0)
                {
                    pieces.Add(vegatebleWeight % size);
                    vegatebleWeight /= size;
                }

                isCutted = true;
            }
            else
            {
                throw new ArgumentException("The vegetable is already cutted!");
            }
            
        }

        /// <summary>
        /// If the vegetable is chopped returns List<double> with all pieces, else return null.
        /// </summary>
        /// <returns></returns>
        public List<double> GetPieces()
        {
            if (isCutted)
            {
                return this.pieces;
            }
            else
            {
                return null;
            }
        }
    }
}
