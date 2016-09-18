using Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Compare_advanced_Maths
{
    public class Sinus
    {
        public static IList<Result> Run()
        {
            List<Result> results = new List<Result>();

            results.Add(SinusFloat());
            results.Add(SinusDouble());
            results.Add(SinusDecimal());

            results.Sort((x, y) => x.AverageTime.CompareTo(y.AverageTime));

            return results;
        }

        private static Result SinusFloat()
        {
            List<TimeSpan> results = new List<TimeSpan>();
            var degrees = 1.0f;
            Stopwatch st = new Stopwatch();
            for (int i = 0; i < Constants.NumberOfCompares; i++)
            {
                degrees += i;
                var angle = Math.PI * degrees / 180.0f;
                st.Reset();
                st.Start();
                for (int j = 0; j < Constants.NumberOfOperations; j++)
                {
                    var sinus = Math.Sin(angle);
                }
                st.Stop();
                results.Add(st.Elapsed);
            }

            long averageTime = (long)results.Average(x => x.Ticks);
            Result res = new Result(averageTime, "float");

            return res;
        }

        private static Result SinusDouble()
        {
            List<TimeSpan> results = new List<TimeSpan>();
            var degrees = 1.0d;
            Stopwatch st = new Stopwatch();
            for (int i = 0; i < Constants.NumberOfCompares; i++)
            {
                degrees += i;
                var angle = Math.PI * degrees / 180.0d;
                st.Reset();
                st.Start();
                for (int j = 0; j < Constants.NumberOfOperations; j++)
                {
                    var sinus = Math.Sin(angle);
                }
                st.Stop();
                results.Add(st.Elapsed);
            }

            long averageTime = (long)results.Average(x => x.Ticks);
            Result res = new Result(averageTime, "double");

            return res;
        }

        private static Result SinusDecimal()
        {
            List<TimeSpan> results = new List<TimeSpan>();
            var degrees = 1.0m;
            Stopwatch st = new Stopwatch();
            for (int i = 0; i < Constants.NumberOfCompares; i++)
            {
                degrees += i;
                var angle = Math.PI * (double)degrees / 180.0;
                st.Reset();
                st.Start();
                for (int j = 0; j < Constants.NumberOfOperations; j++)
                {
                    var sinus = Math.Sin(angle);
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
