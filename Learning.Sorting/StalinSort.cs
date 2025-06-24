using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Sorting
{
    public class StalinSort
    {
        /* 
         * Stalin Sort Algorithm
         * Time Complexity: O(n)
         * Space Complexity: O(n)
         * 
         * This algorithm sorts an array by removing elements that are less than the last seen maximum.
         */
        public static int[] Sort(int[] array, bool minToMax = true)
        {
            if (array == null || array.Length == 0)
                return [];

            List<int> sortedList = new List<int>();
            int threshold = minToMax ? int.MinValue : int.MaxValue;

            foreach (int number in array)
            {
                if (minToMax ? number >= threshold : number <= threshold)
                {
                    threshold = number;
                    sortedList.Add(number);
                }
            }

            return [.. sortedList];
        }
    }
}
