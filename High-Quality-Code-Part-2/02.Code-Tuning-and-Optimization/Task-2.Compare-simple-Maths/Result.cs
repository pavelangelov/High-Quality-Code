using System;

namespace Task_2.Compare_simple_Maths
{
    public class Result
    {
        public Result(long averageTime, string type)
        {
            this.AverageTime = averageTime;
            this.Type = type;
        }

        public long AverageTime { get; set; }

        public string Type { get; set; }

        public override string ToString()
        {
            return $"Type: {this.Type.PadRight(10, ' ')} -> Average time: {new TimeSpan(this.AverageTime)}";
        }
    }
}
