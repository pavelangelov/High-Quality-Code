using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using Common;

namespace Task_4.Compare_sort_algorithms
{
    public class SelectionSortResults
    {
        public static IList<Result> GetResults()
        {
            List<Result> avgResults = new List<Result>();

            avgResults.Add(SorArrayOfInts());
            avgResults.Add(SortArrayOfDoubles());
            avgResults.Add(SortArrayOfStrings());

            avgResults.Sort((x, y) => x.AverageTime.CompareTo(y.AverageTime));

            return avgResults;
        }

        private static Result SorArrayOfInts()
        {
            List<TimeSpan> results = new List<TimeSpan>();
            Stopwatch st = new Stopwatch();
            for (int i = 0; i < 3; i++)
            {
                var intArr = ArrayGenerators.GenerateIntArray(Constants.ArrayLength);
                st.Reset();
                st.Start();

                SortingAlgorythms.SelectionSort(ref intArr);

                st.Stop();
                results.Add(st.Elapsed);
            }

            long average = (long)results.Average(x => x.Ticks);

            return new Result(average, "int");
        }

        private static Result SortArrayOfDoubles()
        {
            List<TimeSpan> results = new List<TimeSpan>();
            Stopwatch st = new Stopwatch();
            for (int i = 0; i < 3; i++)
            {
                var doubleArr = ArrayGenerators.GenerateDoubleArray(Constants.ArrayLength);
                st.Reset();
                st.Start();

                SortingAlgorythms.SelectionSort(ref doubleArr);

                st.Stop();
                results.Add(st.Elapsed);
            }

            long average = (long)results.Average(x => x.Ticks);

            return new Result(average, "double");
        }

        private static Result SortArrayOfStrings()
        {
            List<TimeSpan> results = new List<TimeSpan>();
            Stopwatch st = new Stopwatch();
            for (int i = 0; i < 3; i++)
            {
                var strArr = ArrayGenerators.GenerateDoubleArray(Constants.ArrayLength);
                st.Reset();
                st.Start();

                SortingAlgorythms.SelectionSort(ref strArr);

                st.Stop();
                results.Add(st.Elapsed);
            }

            long average = (long)results.Average(x => x.Ticks);

            return new Result(average, "string");
        }
    }
}
