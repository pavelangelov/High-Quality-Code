using MatrixHomework.Contracts;
using MatrixHomework.Models;
using MatrixHomework.Utils;

namespace MatrixHomework
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            IReader reader = new ConsoleReader();

            // TODO: Delete this when you write the Unit Tests
            logger.WriteLine("Please excuse me but I didn`t have time for the Unit Test! Please understand me. Thanks.");

            int inputNumber = GetMatrixSizeFromUser(logger, reader);
            int[,] matrix = new int[inputNumber, inputNumber];

            MatrixUtils.FillRotatingWalkMatrix(matrix);

            logger = new ConsoleLogger();

            var matrixToString = MatrixUtils.GetMatrixToString(matrix);

            logger.WriteLine(matrixToString);
        }
        
        /// <summary>
        /// Read input from user and when the input is convertable to integer, returns it.
        /// </summary>
        /// <param name="logger">Use it to send message to user if input is invalid.</param>
        /// <param name="reader">Use it to read user`s input.</param>
        /// <returns>Returns Int32.</returns>
        internal static int GetMatrixSizeFromUser(ILogger logger, IReader reader)
        {
            logger.Write(Constants.StartupMessage);
            string input = reader.ReadLine();
            int inputNumber;

            while (!int.TryParse(input, out inputNumber) || 
                    inputNumber < Constants.MinRowAndColValue || 
                    inputNumber > Constants.MaxRowAndColValue)
            {
                logger.WriteLine(Constants.IncorectInputMessage);
                logger.Write(Constants.TryAgainMessage);
                input = reader.ReadLine();
            }

            return inputNumber;
        }
        
    }
}
