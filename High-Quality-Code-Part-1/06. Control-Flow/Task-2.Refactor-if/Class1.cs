namespace Task_2.Refactor
{
    public class Foo
    {
        public void Bar()
        {
            Potato potato;
            //... 
            if (potato != null)
                if (!potato.HasNotBeenPeeled && !potato.IsRotten)
                    Cook(potato);
        }

        public void AnotherBar()
        {
            if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && !shouldNotVisitCell)))
            {
                VisitCell();
            }
        }
    }
}
