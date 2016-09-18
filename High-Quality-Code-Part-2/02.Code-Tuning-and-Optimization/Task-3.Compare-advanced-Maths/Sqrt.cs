using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using Common;

namespace Task_3.Compare_advanced_Maths
{
    public class Sqrt
    {
        public static IList<Result> Run()
        {
            List<Result> results = new List<Result>();

            results.Add(SqrtFloat());
            results.Add(SqrtDouble());
            results.Add(SqrtDecimal());

            results.Sort((x, y) => x.AverageTime.CompareTo(y.AverageTime));

            return results;
        }

        private static Result SqrtFloat()
        {
            List<TimeSpan> results = new List<TimeSpan>();
            var number = 1.0f;
            Stopwatch st = new Stopwatch();
            for (int i = 0; i < Constants.NumberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                for (int j = 0; j < Constants.NumberOfOperations; j++)
                {
                    var sqrt = Math.Sqrt(number + j);
                }
                st.Stop();
                results.Add(st.Elapsed);
            }

            long averageTime = (long)results.Average(x => x.Ticks);
            Result res = new Result(averageTime, "float");

            return res;
        }

        private static Result SqrtDouble()
        {
            List<TimeSpan> results = new List<TimeSpan>();
            var number = 1.0d;
            Stopwatch st = new Stopwatch();
            for (int i = 0; i < Constants.NumberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                for (int j = 0; j < Constants.NumberOfOperations; j++)
                {
                    var sqrt = Math.Sqrt(number + j);
                }
                st.Stop();
                results.Add(st.Elapsed);
            }

            long averageTime = (long)results.Average(x => x.Ticks);
            Result res = new Result(averageTime, "double");

            return res;
        }

        private static Result SqrtDecimal()
        {
            List<TimeSpan> results = new List<TimeSpan>();
            var number = 1.0m;
            Stopwatch st = new Stopwatch();
            for (int i = 0; i < Constants.NumberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                for (int j = 0; j < Constants.NumberOfOperations; j++)
                {
                    var sqrt = Math.Sqrt((double)number + j);
                }
                st.Stop();
                results.Add(st.Elapsed);
            }

            long averageTime = (long)results.Average(x => x.Ticks);
            Result res = new Result(averageTime, "decimal");

            return res;
        }
    }
}
