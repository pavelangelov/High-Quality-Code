using Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Task_4.Compare_sort_algorithms
{
    public class Startup
    {
        public static void Main()
        {
            var results = SelectionSortTest();
            PrintResults.PrintToConsole(results, "selection sort");
        }

        private static IList<Result> SelectionSortTest()
        {
            List<Result> avgResults = new List<Result>();
            int arrLength = 5000;
            List<TimeSpan> results = new List<TimeSpan>();
            Stopwatch st = new Stopwatch();
            for (int i = 0; i < 3; i++)
            {
                var intArr = ArrayGenerators.GenerateIntArray(arrLength);
                st.Reset();
                st.Start();
                SortingAlgorythms.SelectionSort(ref intArr);
                st.Stop();
                results.Add(st.Elapsed);
            }

            long average = (long)results.Average(x => x.Ticks);

            avgResults.Add(new Result(average, "int"));

            results.Clear();
            for (int i = 0; i < 3; i++)
            {
                var doubleArr = ArrayGenerators.GenerateDoubleArray(arrLength);
                st.Reset();
                st.Start();
                SortingAlgorythms.SelectionSort(ref doubleArr);
                st.Stop();
                results.Add(st.Elapsed);
            }

            average = (long)results.Average(x => x.Ticks);

            avgResults.Add(new Result(average, "double"));

            results.Clear();
            for (int i = 0; i < 3; i++)
            {
                var strArr = ArrayGenerators.GenerateDoubleArray(arrLength);
                st.Reset();
                st.Start();
                SortingAlgorythms.SelectionSort(ref strArr);
                st.Stop();
                results.Add(st.Elapsed);
            }

            average = (long)results.Average(x => x.Ticks);

            avgResults.Add(new Result(average, "string"));

            avgResults.Sort((x, y) => x.AverageTime.CompareTo(y.AverageTime));
            return avgResults;
        }
    }
}
