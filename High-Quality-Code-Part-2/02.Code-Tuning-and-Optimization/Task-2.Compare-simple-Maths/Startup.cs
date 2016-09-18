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
            var substractResults = Subtract.GetAverageResults();
            var incrementResults = Increment.Run();
            var multiplyResults = Multiply.Run();
            var dividedResults = Divide.Run();

            PrintResults.PrintToConsole(addResults, "add");
            PrintResults.PrintToConsole(substractResults, "substract");
            PrintResults.PrintToConsole(incrementResults, "increment");
            PrintResults.PrintToConsole(multiplyResults, "multiply");
            PrintResults.PrintToConsole(dividedResults, "divide");
        }
    }
}
