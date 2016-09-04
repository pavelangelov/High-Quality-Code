namespace Task_2.Refactor_if
{
    public class PotatoChecker
    {
        /// <summary>
        /// Create Potato instance and if isn`t peeled and rotten, cook the potato.
        /// </summary>
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
