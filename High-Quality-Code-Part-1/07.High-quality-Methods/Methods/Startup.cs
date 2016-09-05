using System;

namespace Methods
{
    public class Startup
    {
        public static void Main()
        {
            MathCalculationTest();

            TransformingTest();

            PointTest();

            StudentTest();
        }

        private static void MathCalculationTest()
        {
            Console.WriteLine(MathCalculations.CalcTriangleArea(3, 4, 5));

            Console.WriteLine(MathCalculations.FindMax(5, -1, 3, 2, 14, 2, 3));
            Console.WriteLine(MathCalculations.FindMax(new int[] { 5, -1, 3, 2, 14, 2, 3 }));
        }

        private static void TransformingTest()
        {
            TransformNumber.PrintFormatedNumber(1.3, FormatType.Floating);
            TransformNumber.PrintFormatedNumber(0.75, FormatType.Percent);
            TransformNumber.PrintFormatedNumber(2.30, FormatType.PadLeft);

            Console.WriteLine(TransformNumber.NumberToDigit(5));
        }

        private static void PointTest()
        {
            double x1 = 3;
            double y1 = -1;
            double x2 = 3;
            double y2 = 2.5;
            bool horizontal = MathCalculations.IsHorizontal(y1, y2);
            bool vertical = MathCalculations.IsVertical(x1, x2);

            Console.WriteLine(MathCalculations.CalcDistance(x1, y1, x2, y2));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);
        }

        private static void StudentTest()
        {
            Student peter = new Student("Peter", "Ivanov", 24);
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student("Stella", "Markova", 23);
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
