using Common;
using Task_2.Compare_simple_Maths.SimpleMathsCompares;

namespace Task_2.Compare_simple_Maths
{
    public class Startup
    {
        public static void Main()
        {
            /*
             * All results are calculated with 1 000 000 operations, repeated 10 times to get the average needed time 
             * for executing the operation.
             */
            var addResults = Add.Run();
            PrintResults.PrintToConsole(addResults, "add");

            var substractResults = Subtract.GetAverageResults();
            PrintResults.PrintToConsole(substractResults, "substract");

            var incrementResults = Increment.Run();
            PrintResults.PrintToConsole(incrementResults, "increment");

            var multiplyResults = Multiply.Run();
            PrintResults.PrintToConsole(multiplyResults, "multiply");

            var dividedResults = Divide.Run();
            PrintResults.PrintToConsole(dividedResults, "divide");
        }
    }
}
