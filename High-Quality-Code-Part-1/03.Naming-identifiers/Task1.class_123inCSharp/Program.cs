using System;

namespace Task1.class_123inCSharp
{
    class Foo
    {
        const int MaxCount = 6;

        class Bar
        {
            internal void PrintTrueOrFalseToConsole(bool booleanToPrint)
            {
                string output = booleanToPrint.ToString();
                Console.WriteLine(output);
            }
        }
        public static void Метод_За_Вход()
        {
            Foo.Bar fooBar = new Foo.Bar();
            fooBar.PrintTrueOrFalseToConsole(true);
        }
    }
}
