using System.Text;

using Common;

namespace Task_3.Compare_advanced_Maths
{
    public class Startup
    {
        public static void Main()
        {
            StringBuilder startMessage = new StringBuilder();
            startMessage.AppendLine("This program calculates average time for calculating Square Root, Natural Logaryth and Sinus with different data types.");
            startMessage.AppendLine($"For every data type is calculated average time for {Constants.NumberOfOperations} calculatons.");

            System.Console.WriteLine(startMessage);

            var sqrtResults = Sqrt.Run();
            PrintResults.PrintToConsole(sqrtResults, "sqrt");

            var logResults = NaturalLogarithm.Run();
            PrintResults.PrintToConsole(logResults, "natural logarithm");

            var sinusResults = Sinus.Run();
            PrintResults.PrintToConsole(sinusResults, "sinus");
        }
    }
}
