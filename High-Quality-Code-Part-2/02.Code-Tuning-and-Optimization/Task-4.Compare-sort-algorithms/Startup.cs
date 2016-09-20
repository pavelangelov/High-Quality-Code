using Common;
using System.Text;

namespace Task_4.Compare_sort_algorithms
{
    public class Startup
    {
        public static void Main()
        {
            StringBuilder startMessage = new StringBuilder();
            startMessage.AppendLine("This program calculates average time for sorting array of elements with Selection Sort Algorythm for int, double and string array.");
            startMessage.AppendLine($"For every data type is calculated average time for sorting array of {Constants.ArrayLength} elements.");

            System.Console.WriteLine(startMessage);

            var results = SelectionSortResults.GetResults();

            PrintResults.PrintToConsole(results, "selection sort");
        }
    }
}
