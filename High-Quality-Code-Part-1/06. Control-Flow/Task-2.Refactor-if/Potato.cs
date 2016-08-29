namespace Task_2.Refactor_if
{
    public class Potato
    {
        private bool isPeeled;
        private bool isRotten;

        public Potato()
        {
            this.isPeeled = false;
            this.isRotten = false;
            this.IsCoocked = false;
        }

        public bool IsPeeled
        {
            get
            {
                return this.isPeeled;
            }
        }

        public bool IsRotten
        {
            get
            {
                return this.isRotten;
            }
        }

        public bool IsCoocked { get; set; }
    }
}
