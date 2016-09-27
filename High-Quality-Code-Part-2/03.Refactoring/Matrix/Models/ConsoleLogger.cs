using System;

using MatrixHomework.Contracts;

namespace MatrixHomework.Models
{
    public class ConsoleLogger : ILogger
    {
        /// <summary>
        /// Initializes a new instance of tha class <see cref="ConsoleLogger"/>.
        /// </summary>
        public ConsoleLogger()
        {
        }

        /// <summary>
        /// Writes specified string value to the console.
        /// </summary>
        /// <param name="text"></param>
        public void Write(string text)
        {
            Console.Write(text);
        }

        /// <summary>
        /// Writes specified string value, followed by the current line terminator, to the console.
        /// </summary>
        /// <param name="text"></param>
        public void WriteLine(string text = null)
        {
            Console.WriteLine(text);
        }
    }
}
