using System;

namespace Task_1.Class_Chef.Models
{
    public class Carrot : Vegetable
    {
        public Carrot(double weight)
            :base(weight)
        {
        }

        public override void Peel()
        {
            var peelsWeight = this.Weight / 8;

            this.Weight -= peelsWeight;
        }
    }
}
