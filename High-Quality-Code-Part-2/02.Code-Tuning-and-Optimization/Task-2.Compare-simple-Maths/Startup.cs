using System.Text;

using Common;
using Task_2.Compare_simple_Maths.SimpleMathsCompares;

namespace Task_2.Compare_simple_Maths
{
    public class Startup
    {
        public static void Main()
        {

            StringBuilder startMessage = new StringBuilder();
            startMessage.AppendLine("This program calculates average time for calculating Add, Subtract, Increment, Multiply and Divide with different data types.");
            startMessage.AppendLine($"For every data type is calculated average time for {Constants.NumberOfOperations} calculatons.");

            System.Console.WriteLine(startMessage);

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
