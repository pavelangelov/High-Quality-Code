using System;

using Cohesion_and_Coupling.Utils;

namespace Cohesion_and_Coupling
{
    public class UtilsExamples
    {
        /// <summary>
        /// Start the program.
        /// </summary>
        public static void Main()
        {
            FileUtileExamples();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            PointUtilsExamples();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            BoxUtilsExamples();
        }

        private static void FileUtileExamples()
        {
            var fileNames = new string[]
            {
                "example",
                "example.pdf",
                "example.new.pdf"
            };
            foreach (var fileName in fileNames)
            {
                try
                {
                    var fileExtension = FileUtils.GetFileExtension(fileName);
                    Console.WriteLine($"File extension of \"{fileName}\" is: {fileExtension}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            foreach (var fileName in fileNames)
            {
                try
                {
                    var nameWithoutExtension = FileUtils.GetFileNameWithoutExtension(fileName);
                    Console.WriteLine($"File name without extension from \"{fileName}\" is: {nameWithoutExtension}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        private static void PointUtilsExamples()
        {
            var firstPoint = new Point3D(1, -2, 0);
            var secondPoint = new Point3D(3, 4, 0);
            Console.WriteLine("Distance in the 2D space = {0:f2}",
                PointUtils.CalcDistance2D(firstPoint, secondPoint));

            firstPoint.Z = -1;
            secondPoint.Z = 4;
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                PointUtils.CalcDistance3D(firstPoint, secondPoint));
        }

        private static void BoxUtilsExamples()
        {
            var box = new Box(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", BoxUtils.CalcVolume(box));
            Console.WriteLine("Diagonal XYZ = {0:f2}", BoxUtils.CalcDiagonalXYZ(box));
            Console.WriteLine("Diagonal XY = {0:f2}", BoxUtils.CalculateSideDiagonal(box.Width, box.Height));
            Console.WriteLine("Diagonal XZ = {0:f2}", BoxUtils.CalculateSideDiagonal(box.Width, box.Depth));
            Console.WriteLine("Diagonal YZ = {0:f2}", BoxUtils.CalculateSideDiagonal(box.Height, box.Depth));
        }
    }
}
