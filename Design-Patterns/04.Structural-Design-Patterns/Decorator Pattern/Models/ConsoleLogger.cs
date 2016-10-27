using System;

using Decorator_Pattern.Contracts;

namespace Decorator_Pattern.Models
{
    public class ConsoleLogger : ILogger
    {
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
