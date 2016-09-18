using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Compare_simple_Maths.SimpleMathsCompares
{
    public class Divide
    {
        public static IList<Result> Run()
        {
            var results = new List<Result>();

            results.Add(DivideInt());
            results.Add(DivideLong());
            results.Add(DivideFloat());
            results.Add(DivideDouble());
            results.Add(DivideDecimal());

            results.Sort((x, y) => x.AverageTime.CompareTo(y.AverageTime));

            return results;
        }

        private static Result DivideInt()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            int divider = 2;
            int result;
            Stopwatch st = new Stopwatch();

            for (int i = 0; i < Constants.numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                result = int.MaxValue;
                for (int j = 0; j < Constants.numberOfOperations; j++)
                {
                    result /= divider;
                }

                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);

            var res = new Result(averageTime, "int");

            return res;
        }

        private static Result DivideLong()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            long divider = 2L;
            long result;
            Stopwatch st = new Stopwatch();

            for (int i = 0; i < Constants.numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                result = long.MaxValue;
                for (int j = 0; j < Constants.numberOfOperations; j++)
                {
                    result /= divider;
                }

                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);

            var res = new Result(averageTime, "long");

            return res;
        }

        private static Result DivideFloat()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            float divider = 2.0f;
            float result;
            Stopwatch st = new Stopwatch();

            for (int i = 0; i < Constants.numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                result = float.MaxValue;
                for (int j = 0; j < Constants.numberOfOperations; j++)
                {
                    result /= divider;
                }

                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);

            var res = new Result(averageTime, "float");

            return res;
        }

        private static Result DivideDouble()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            double divider = 2.0;
            double result;
            Stopwatch st = new Stopwatch();

            for (int i = 0; i < Constants.numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                result = double.MaxValue;
                for (int j = 0; j < Constants.numberOfOperations; j++)
                {
                    result /= divider;
                }

                st.Stop();
                neededTimes.Add(st.Elapsed);
            }

            long averageTime = (long)neededTimes.Average(x => x.Ticks);

            var res = new Result(averageTime, "double");

            return res;
        }

        private static Result DivideDecimal()
        {
            List<TimeSpan> neededTimes = new List<TimeSpan>();
            decimal numberToMultiply = 1.00001m;
            decimal result;
            Stopwatch st = new Stopwatch();

            for (int i = 0; i < Constants.numberOfCompares; i++)
            {
                st.Reset();
                st.Start();
                result = decimal.MaxValue;
                for (int j = 0; j < Constants.numberOfOperations; j++)
                {
                    result /= numberToMultiply;
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
