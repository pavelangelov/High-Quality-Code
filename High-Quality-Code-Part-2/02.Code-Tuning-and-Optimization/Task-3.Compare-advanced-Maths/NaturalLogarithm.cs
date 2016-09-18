using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using Common;

namespace Task_3.Compare_advanced_Maths
{
    public class NaturalLogarithm
    {
        public static IList<Result> Run()
        {
            List<Result> results = new List<Result>();

            results.Add(NaturalLogarithmFloat());
            results.Add(NaturalLogarithmDouble());
            results.Add(NaturalLogarithmDecimal());

            results.Sort((x, y) => x.AverageTime.CompareTo(y.AverageTime));

            return results;
        }

        private static Result NaturalLogarithmFloat()
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
                    var sqrt = Math.Log(number);
                }
                st.Stop();
                results.Add(st.Elapsed);
            }

            long averageTime = (long)results.Average(x => x.Ticks);
            Result res = new Result(averageTime, "float");

            return res;
        }

        private static Result NaturalLogarithmDouble()
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
                    var sqrt = Math.Log(number);
                }
                st.Stop();
                results.Add(st.Elapsed);
            }

            long averageTime = (long)results.Average(x => x.Ticks);
            Result res = new Result(averageTime, "double");

            return res;
        }

        private static Result NaturalLogarithmDecimal()
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
                    var sqrt = Math.Log((double)number);
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
