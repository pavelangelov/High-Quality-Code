using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Task_2.Compare_simple_Maths.SimpleMathsCompares
{
    public class Increment
    {
        /// <summary>
        /// Calculate average time for increment with different types.
        /// </summary>
        public static IList<Result> Run()
        {
            var results = new List<Result>();

            results.Add(IncrementWithInt());
            results.Add(IncrementWithLong());
            results.Add(IncrementWithFloat());
            results.Add(IncrementWithDouble());
            results.Add(IncrementWithDecimal());

            results.Sort((x, y) => x.AverageTime.CompareTo(y.AverageTime));

            return results;
        }

        private static Result IncrementWithInt()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int numberOfCompares = 10;
            int numberOfIncrements = 1000000;
            Stopwatch st = new Stopwatch();
            int number = 0;

            for (int i = 0; i < numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                for (int j = 0; j < numberOfIncrements; j++)
                {
                    number++;
                }
                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);

            var res = new Result(averageTime, "int");

            return res;
        }

        private static Result IncrementWithLong()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int numberOfCompares = 10;
            int numberOfIncrements = 1000000;
            Stopwatch st = new Stopwatch();
            long number = 0;

            for (int i = 0; i < numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                for (int j = 0; j < numberOfIncrements; j++)
                {
                    number++;
                }
                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);

            var res = new Result(averageTime, "long");

            return res;
        }

        private static Result IncrementWithFloat()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int numberOfCompares = 10;
            int numberOfIncrements = 1000000;
            Stopwatch st = new Stopwatch();
            float number = 0;

            for (int i = 0; i < numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                for (int j = 0; j < numberOfIncrements; j++)
                {
                    number++;
                }
                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);

            var res = new Result(averageTime, "float");

            return res;
        }

        private static Result IncrementWithDouble()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int numberOfCompares = 10;
            int numberOfIncrements = 1000000;
            Stopwatch st = new Stopwatch();
            double number = 0;

            for (int i = 0; i < numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                for (int j = 0; j < numberOfIncrements; j++)
                {
                    number++;
                }
                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);

            var res = new Result(averageTime, "double");

            return res;
        }

        private static Result IncrementWithDecimal()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int numberOfCompares = 10;
            int numberOfIncrements = 1000000;
            Stopwatch st = new Stopwatch();
            decimal number = 0;

            for (int i = 0; i < numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                for (int j = 0; j < numberOfIncrements; j++)
                {
                    number++;
                }
                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);

            averageTime = (long)neededTimes.Average(x => x.Ticks);

            var res = new Result(averageTime, "decimal");

            return res;
        }
    }
}
