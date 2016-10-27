using System;

using Adapter_Pattern.Contracts;

namespace Adapter_Pattern.Models
{
    public class ConsoleLogger : ILogger
    {
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
