using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public static class PrintResults
    {
        public static void PrintToConsole(IList<Result> results, string operation)
        {
            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"Table with average time for {operation} operation with different types.");
            Console.WriteLine(new string('-', 38));
            StringBuilder result = new StringBuilder();
            int position = 1;
            for (int i = 0; i < results.Count; i++)
            {
                var currentResult = results[i];
                var centeredType = currentResult.Type.CenterString(10);
                var caverageTime = new TimeSpan(currentResult.AverageTime);
                string line = $"|{position.ToString().PadLeft(3)}.| {centeredType} | {caverageTime} |";
                
                result.AppendLine(line);
                position++;
            }

            Console.WriteLine(result.ToString().TrimEnd());
            Console.WriteLine(new string('-', 38));
        }

        public static string CenterString(this string stringToCenter, int totalLength)
        {
            return stringToCenter.PadLeft(((totalLength - stringToCenter.Length) / 2)
                                + stringToCenter.Length)
                       .PadRight(totalLength);
        }
    }
}
