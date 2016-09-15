using System;
using System.Collections.Generic;

using Exceptions_Homework.Utils;

public class ExceptionsHomework
{
    /// <summary>
    /// Retrieves a array contained subsuquence of elements from original array.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="arr">Array of elements.</param>
    /// <param name="startIndex">Start index of the subsequence.</param>
    /// <param name="count">Number of elements to copy.</param>
    /// <returns>Returns new T[].</returns>
    /// <exception cref="ArgumentException"/>
    /// <exception cref="ArgumentOutOfRangeException"/>
    /// <exception cref="NullReferenceException"/>
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        Validator.CheckForNull(arr, "Array cannot be null!");
        Validator.CheckIfNumberIsLessThanZero(startIndex, "startIndex cannot be less than 0!");
        Validator.CheckIfNumberIsInRange(count, arr.Length - startIndex, 0, "count");

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    /// <summary>
    /// Returns new string, contains last "count" characters from original string.
    /// </summary>
    /// <param name="str">String from where to extract.</param>
    /// <param name="count">Number of characters.</param>
    /// <returns>Returns string.</returns>
    /// <exception cref="ArgumentException"/>
    public static string ExtractEnding(string str, int count)
    {
        if (count > str.Length)
        {
            throw new ArgumentException("Count cannot be greater than string length!");
        }

        var startIndex = str.Length - count;
        var result = str.Substring(startIndex);

        return result;
    }

    /// <summary>
    /// Check if number is prime. Returns true or false.
    /// </summary>
    /// <param name="number">Number to check.</param>
    /// <returns>Returns boolean.</returns>
    public static bool CheckPrime(int number)
    {
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// Start the program.
    /// </summary>
    public static void Main()
    {
        SubsequenceTests();

        StringTests();

        PrimeNumberTests();

        StudentTests();
    }

    private static void SubsequenceTests()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(String.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyarr));
    }

    private static void StringTests()
    {
        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        try
        {
            Console.WriteLine(ExtractEnding("Hi", 100));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("\nExtractEnding from string \"Hi\", with count 100, throws error with message:");
            Console.WriteLine(ex.Message);
            Console.WriteLine();
        }
    }

    private static void PrimeNumberTests()
    {
        int firstNumber = 23;
        Console.WriteLine($"{firstNumber} is prime? -> {CheckPrime(firstNumber)}");

        int secondNumber = 33;
        Console.WriteLine($"{secondNumber} is prime? -> {CheckPrime(secondNumber)}");
    }

    private static void StudentTests()
    {
        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
