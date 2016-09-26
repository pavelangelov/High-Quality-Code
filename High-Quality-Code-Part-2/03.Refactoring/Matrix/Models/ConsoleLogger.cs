using MatrixHomework.Contracts;
using System;

namespace MatrixHomework.Models
{
    public class ConsoleLogger : ILogger
    {
        public ConsoleLogger()
        {
        }

        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(string text = null)
        {
            Console.WriteLine(text);
        }
    }
}
