using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using Common;

namespace Task_2.Compare_simple_Maths.SimpleMathsCompares
{
    /// <summary>
    /// Calculate average time for subtract with different types.
    /// </summary>
    public class Subtract
    {
        /// <summary>
        /// Startup the tests.
        /// </summary>
        public static IList<Result> GetAverageResults()
        {
            List<Result> results = new List<Result>();

            results.Add(SubtractWithInt());
            results.Add(SubtractWithLong());
            results.Add(SubtractWithFloat());
            results.Add(SubtractWithDouble());
            results.Add(SubtractWithDecimal());

            results.Sort((x, y) => x.AverageTime.CompareTo(y.AverageTime));

            return results;
        }

        private static Result SubtractWithInt()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int numberOfCompares = 10;
            int numberOfSubtracts = 1000000;
            int numberToSubtract = 2;
            int result;
            Stopwatch st = new Stopwatch();

            for (int i = 0; i < numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                result = int.MaxValue;
                for (int j = 0; j < numberOfSubtracts; j++)
                {
                    result -= numberToSubtract;
                }

                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);
            Result res = new Result(averageTime, "int");

            //Console.WriteLine($"The average time for {numberOfSubtracts} subtract operations with int is:        {new TimeSpan(averageTime)}");

            return res;
        }

        private static Result SubtractWithLong()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int numberOfCompares = 10;
            int numberOfSubtracts = 1000000;
            long numberToSubtract = 10;
            long result;
            Stopwatch st = new Stopwatch();

            for (int i = 0; i < numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                result = long.MaxValue;
                for (int j = 0; j < numberOfSubtracts; j++)
                {
                    result -= numberToSubtract;
                }

                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);
            //Console.WriteLine($"The average time for {numberOfSubtracts} subtract operations with long is:       {new TimeSpan(averageTime)}");

            Result res = new Result(averageTime, "long");

            return res;
        }

        private static Result SubtractWithFloat()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int numberOfCompares = 10;
            int numberOfAdds = 1000000;
            float numberToSubtract = 10f;
            float result;
            Stopwatch st = new Stopwatch();

            for (int i = 0; i < numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                result = float.MaxValue;
                for (int j = 0; j < numberOfAdds; j++)
                {
                    result -= numberToSubtract;
                }

                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);
            //Console.WriteLine($"The average time for {numberOfAdds} subtract operations with float is:      {new TimeSpan(averageTime)}");

            Result res = new Result(averageTime, "float");

            return res;
        }

        private static Result SubtractWithDouble()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int numberOfCompares = 10;
            int numberOfAdds = 1000000;
            double numberToSubtract = 10;
            double result;
            Stopwatch st = new Stopwatch();

            for (int i = 0; i < numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                result = double.MaxValue;
                for (int j = 0; j < numberOfAdds; j++)
                {
                    result -= numberToSubtract;
                }

                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);
            //Console.WriteLine($"The average time for {numberOfAdds} subtract operations with double is:     {new TimeSpan(averageTime)}");

            Result res = new Result(averageTime, "double");

            return res;
        }

        private static Result SubtractWithDecimal()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int numberOfCompares = 10;
            int numberOfAdds = 1000000;
            decimal numberToSubtract = 1m;
            decimal result;
            Stopwatch st = new Stopwatch();

            for (int i = 0; i < numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                result = decimal.MaxValue;
                for (int j = 0; j < numberOfAdds; j++)
                {
                    result -= numberToSubtract;
                }

                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);
            //Console.WriteLine($"The average time for {numberOfAdds} subtract operations with decimal is:    {new TimeSpan(averageTime)}");

            Result res = new Result(averageTime, "decimal");

            return res;
        }
    }
}
