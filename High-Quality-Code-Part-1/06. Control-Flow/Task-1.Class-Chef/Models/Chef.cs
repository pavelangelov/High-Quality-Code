namespace Task_1.Class_Chef.Models
{
    using Vegetables;

    public class Chef
    {
        private Bowl GetBowl()
        {
            return Store.GetBowl();
        }

        private Carrot GetCarrot()
        {
            return Store.GetCarrot();
        }

        private void Cut(Vegetable vegetable)
        {
            var piecesSize = 5;
            vegetable.Cutted(piecesSize);
        }

        public void Cook()
        {
            Bowl bowl = GetBowl();
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();

            Peel(potato);
            Peel(carrot);

            Cut(potato);
            Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Potato GetPotato()
        {
            return Store.GetPotato();
        }

        private void Peel(Vegetable vegetable)
        {
            vegetable.Peel();
        }
    }
}
