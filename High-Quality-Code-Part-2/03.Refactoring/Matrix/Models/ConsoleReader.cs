using System;
using MatrixHomework.Contracts;

namespace MatrixHomework.Models
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            string result = Console.ReadLine();

            return result;
        }
    }
}
