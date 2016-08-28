using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Refactor_loop
{
    public class Class1
    {
        public void SomeMethod()
        {
            int i = 0;
            for (i = 0; i < 100;)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        i = 666;
                    }
                    i++;
                }
                else
                {
                    Console.WriteLine(array[i]);
                    i++;
                }
            }
            // More code here
            if (i == 666)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
