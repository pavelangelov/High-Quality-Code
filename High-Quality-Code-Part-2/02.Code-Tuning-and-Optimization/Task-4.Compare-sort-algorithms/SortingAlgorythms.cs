using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Compare_sort_algorithms
{
    public class SortingAlgorythms
    {
        public static void SelectionSort<T>(ref T[] array) where T : IComparable<T>
        {
            int index = -1;
            T currentValue;
            for (int i = 0; i < array.Length; i++)
            {
                T min = array[i];
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j].CompareTo(min) < 0)
                    {
                        min = array[j];
                        index = j;
                    }
                }
                if (index >= 0)
                {
                    currentValue = array[i];
                    array[i] = min;
                    array[index] = currentValue;
                }
                
                index = -1;

            }
        }
    }
}
