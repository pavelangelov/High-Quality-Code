namespace Task_2.Refactor_if
{
    public class PotatoChecker
    {
        public void CheckBeforeCook()
        {
            Potato potato = new Potato();

            if (potato != null)
            {
                if (!potato.IsPeeled && !potato.IsRotten)
                {
                    Cook(potato);
                }
            }
        }

        private void Cook(Potato potato)
        {
            potato.IsCoocked = true;
        }
    }
}
