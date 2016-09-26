namespace MatrixHomework
{
    public static class Constants
    {
        internal const int MinRowAndColValue = 1;
        internal const int MaxRowAndColValue = 100;
        internal const int StartRow = 0;
        internal const int StartCol = 0;
        internal const int CellsStartValue = 1;

        internal const string StartupMessage = "Please enter a positive number: ";
        internal const string IncorectInputMessage = "You haven't entered a correct positive number!";
        internal const string TryAgainMessage = "Please try again: ";

        internal static readonly string[] directions = new string[]
            {
                "DownRight",
                "Down",
                "DownLeft",
                "Left",
                "UpLeft",
                "Up",
                "UpRight",
                "Right"
            };

    }
}
