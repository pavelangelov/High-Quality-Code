namespace Task_1.Class_Chef.Models.Vegetables
{
    public class Carrot : Vegetable
    {
        private const double CarrotPeelsWeightInPercent = 8;

        public Carrot(double weight)
            :base(weight)
        {
        }

        /// <summary>
        /// Peel the Carrot. This will decrease his weight with 8%.
        /// </summary>
        public override void Peel()
        {
            var peelsWeight = this.Weight / CarrotPeelsWeightInPercent;

            this.Weight -= peelsWeight;
        }
    }
}
