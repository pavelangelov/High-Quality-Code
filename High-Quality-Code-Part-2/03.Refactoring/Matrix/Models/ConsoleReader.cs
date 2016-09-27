using System;

using MatrixHomework.Contracts;

namespace MatrixHomework.Models
{
    public class ConsoleReader : IReader
    {
        /// <summary>
        /// Initializes a new instance of tha class <see cref="ConsoleReader"/>.
        /// </summary>
        public ConsoleReader()
        {
        }

        /// <summary>
        /// Read input from the console.
        /// </summary>
        /// <returns>Returns string.</returns>
        public string ReadLine()
        {
            string result = Console.ReadLine();

            return result;
        }
    }
}
