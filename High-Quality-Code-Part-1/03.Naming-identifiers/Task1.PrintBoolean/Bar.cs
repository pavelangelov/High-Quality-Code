namespace Task1.PrintBoolean
{
    using System;

    internal class Bar
    {
        internal void PrintTrueOrFalseToConsole(bool booleanToPrint)
        {
            string output = booleanToPrint.ToString();
            Console.WriteLine(output);
        }
    }
}
