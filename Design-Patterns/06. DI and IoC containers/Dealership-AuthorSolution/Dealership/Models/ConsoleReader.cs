using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            var text = Console.ReadLine();

            return text;
        }
    }
}
