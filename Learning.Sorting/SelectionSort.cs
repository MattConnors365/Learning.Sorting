using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Sorting
{
    public class SelectionSort
    {
        /* 
         * Selection Sort Algorithm
         * Time Complexity: O(n^2)
         * Space Complexity: O(1)
         * 
         * From W3Schools, requirements:
         * 1. An array with values to sort.
         * 2. An inner loop that goes through the array, finds the lowest value, and moves it to the front of the array. This loop must loop through one less value each time it runs.
         * 3. An outer loop that controls how many times the inner loop must run. 
         * For an array with n values, this outer loop must run n − 1 times.
         */
        public static int[] Sort(int[] array, bool minToMax = true)
        {
            int[] result = (int[])array.Clone(); // Make a copy of the array

            for (int i = 0; i < result.Length - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (minToMax ? result[j] < result[index] : result[j] > result[index])
                    {
                        index = j;
                    }
                }
                (result[i], result[index]) = (result[index], result[i]);
            }

            return result;
        }
    }
}
