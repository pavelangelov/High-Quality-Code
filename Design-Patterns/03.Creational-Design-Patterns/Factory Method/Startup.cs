using System;

using Factory_Method.Contracts;
using Factory_Method.Enums;
using Factory_Method.Models;

namespace Factory_Method
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var factory = new GsmFactory();
            var phones = new IGsm[]
            {
                factory.CreateGsm(GsmModel.Galaxy),
                factory.CreateGsm(GsmModel.IPhone)
            };

            foreach (var gsm in phones)
            {
                Console.WriteLine(gsm);
                Console.WriteLine();
            }
        }
    }
}
