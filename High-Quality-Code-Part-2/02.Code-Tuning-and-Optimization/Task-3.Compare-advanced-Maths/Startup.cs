using Common;

namespace Task_3.Compare_advanced_Maths
{
    public class Startup
    {
        public static void Main()
        {
            var sqrtResults = Sqrt.Run();
            PrintResults.PrintToConsole(sqrtResults, "sqrt");

            var logResults = NaturalLogarithm.Run();
            PrintResults.PrintToConsole(logResults, "natural logarithm");

            var sinusResults = Sinus.Run();
            PrintResults.PrintToConsole(sinusResults, "sinus");
        }
    }
}
