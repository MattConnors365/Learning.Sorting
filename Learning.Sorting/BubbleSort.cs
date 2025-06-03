using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Sorting
{
    internal class BubbleSort
    {
        /*
         * Bubble Sort Algorithm
         * Time Complexity: O(n^2)
         * Space Complexity: O(1)
         * 
         * From W3Schools, requirements:
         * 1. An array with values to sort.
         * 2. An inner loop that goes through the array and swaps values if the first value is higher than the next value. This loop must loop through one less value each time it runs.
         * 3. An outer loop that controls how many times the inner loop must run. For an array with n values, this outer loop must run n-1 times.
         */
        public static int[] Sort(int[] array, bool minToMax = true)
        {
            int prev1 = array[0], prev2 = array[1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int n = 0; n < array.Length - i - 1; n++)
                {
                    if (minToMax)
                    {
                        if (array[n] > array[n + 1])
                        {
                            int temp = array[n];
                            array[n] = array[n + 1];
                            array[n + 1] = temp;
                        }
                    }
                    else
                    {
                        if (array[n] < array[n + 1])
                        {
                            int temp = array[n];
                            array[n] = array[n + 1];
                            array[n + 1] = temp;
                        }
                    }
                }
            }
            return array;
        }
    }
}
