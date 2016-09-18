using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Task_2.Compare_simple_Maths.SimpleMathsCompares
{
    /// <summary>
    /// Calculate average time for add with different types.
    /// </summary>
    public class Add
    {
        public static IList<Result> Run()
        {
            var results = new List<Result>();

            results.Add(CompareAddWithInt());
            results.Add(CompareAddWithLong());
            results.Add(CompareAddWithFloat());
            results.Add(CompareAddWithDouble());
            results.Add(CompareAddWithDecimal());

            results.Sort((x, y) => x.AverageTime.CompareTo(y.AverageTime));

            return results;
        }

        private static Result CompareAddWithInt()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int numberOfCompares = 10;
            int numberOfAdds = 1000000;
            int numberToAdd = 2;
            int result;
            Stopwatch st = new Stopwatch();

            for (int i = 0; i < numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                result = 0;
                for (int j = 0; j < numberOfAdds; j++)
                {
                    result += numberToAdd;
                }

                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);

            var res = new Result(averageTime, "int");

            return res;
        }

        private static Result CompareAddWithLong()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int numberOfCompares = 10;
            int numberOfAdds = 1000000;
            long numberToAdd = 10;
            long result;
            Stopwatch st = new Stopwatch();

            for (int i = 0; i < numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                result = 0;
                for (int j = 0; j < numberOfAdds; j++)
                {
                    result += numberToAdd;
                }

                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);

            var res = new Result(averageTime, "long");

            return res;
        }

        private static Result CompareAddWithFloat()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int numberOfCompares = 10;
            int numberOfAdds = 1000000;
            float numberToAdd = 10f;
            float result;
            Stopwatch st = new Stopwatch();

            for (int i = 0; i < numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                result = 0f;
                for (int j = 0; j < numberOfAdds; j++)
                {
                    result += numberToAdd;
                }

                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);

            var res = new Result(averageTime, "float");

            return res;
        }

        private static Result CompareAddWithDouble()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int numberOfCompares = 10;
            int numberOfAdds = 1000000;
            double numberToAdd = 10;
            double result;
            Stopwatch st = new Stopwatch();

            for (int i = 0; i < numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                result = 0;
                for (int j = 0; j < numberOfAdds; j++)
                {
                    result += numberToAdd;
                }

                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);

            var res = new Result(averageTime, "double");

            return res;
        }

        private static Result CompareAddWithDecimal()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int numberOfCompares = 10;
            int numberOfAdds = 1000000;
            decimal numberToAdd = 1m;
            decimal result;
            Stopwatch st = new Stopwatch();

            for (int i = 0; i < numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                result = 0m;
                for (int j = 0; j < numberOfAdds; j++)
                {
                    result += numberToAdd;
                }

                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);

            var res = new Result(averageTime, "decimal");

            return res;
        }
    }
}
