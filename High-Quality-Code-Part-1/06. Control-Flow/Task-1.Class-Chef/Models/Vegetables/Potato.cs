namespace Task_1.Class_Chef.Models.Vegetables
{
    public class Potato : Vegetable
    {
        public Potato(double weight)
            : base(weight)
        {
        }

        public override void Peel()
        {
            var peelsWeight = this.Weight / 10;
            this.Weight -= peelsWeight;
        }
    }
}
