using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Task_2.Compare_simple_Maths.SimpleMathsCompares
{
    /// <summary>
    /// Calculate average time for multiply with different types.
    /// </summary>
    public class Multiply
    {
        public static IList<Result> Run()
        {
            var results = new List<Result>();

            results.Add(MultiplyInt());
            results.Add(MultiplyLong());
            results.Add(MultiplyFloat());
            results.Add(MultiplyDouble());
            results.Add(MultiplyDecimal());

            results.Sort((x, y) => x.AverageTime.CompareTo(y.AverageTime));

            return results;
        }

        private static Result MultiplyInt()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int numberOfCompares = 10;
            int numberOfMultiplies = 1000000;
            int numberToMultiply = 2;
            int result;
            Stopwatch st = new Stopwatch();

            for (int i = 0; i < numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                result = 1;
                for (int j = 0; j < numberOfMultiplies; j++)
                {
                    result *= numberToMultiply;
                }

                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);

            var res = new Result(averageTime, "int");

            return res;
        }

        private static Result MultiplyLong()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int numberOfCompares = 10;
            int numberOfMultiplies = 1000000;
            long numberToMultiply = 2L;
            long result;
            Stopwatch st = new Stopwatch();

            for (int i = 0; i < numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                result = 1;
                for (int j = 0; j < numberOfMultiplies; j++)
                {
                    result *= numberToMultiply;
                }

                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);

            var res = new Result(averageTime, "long");

            return res;
        }

        private static Result MultiplyFloat()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int numberOfCompares = 10;
            int numberOfMultiplies = 1000000;
            float numberToMultiply = 2.0f;
            float result;
            Stopwatch st = new Stopwatch();

            for (int i = 0; i < numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                result = 1.0f;
                for (int j = 0; j < numberOfMultiplies; j++)
                {
                    result *= numberToMultiply;
                }

                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);

            var res = new Result(averageTime, "float");

            return res;
        }

        private static Result MultiplyDouble()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int numberOfCompares = 10;
            int numberOfMultiplies = 1000000;
            double numberToMultiply = 2.0d;
            double result;
            Stopwatch st = new Stopwatch();

            for (int i = 0; i < numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                result = 1.0;
                for (int j = 0; j < numberOfMultiplies; j++)
                {
                    result *= numberToMultiply;
                }

                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);

            var res = new Result(averageTime, "double");

            return res;
        }

        private static Result MultiplyDecimal()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int numberOfCompares = 10;
            int numberOfMultiplies = 1000000;
            decimal numberToMultiply = 1.000000001m;
            decimal result;
            Stopwatch st = new Stopwatch();

            for (int i = 0; i < numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                result = 1.0m;
                for (int j = 0; j < numberOfMultiplies; j++)
                {
                    result *= numberToMultiply;
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
