using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCore
{
    public static class Selection_Sort
    {
        public static List<int> DoMinSelectionSort(List<int> unsortedList) {
            List<int> result = new List<int>();
            var count = unsortedList.Count;
            for (int i = 0; i < count; i++)
            {
                int smallestIndex = FindSmallest(unsortedList);
                result.Add(unsortedList[smallestIndex]);
                unsortedList.RemoveAt(smallestIndex);
            }
            return result;
        }

        public static int FindSmallest(List<int> unsortedList) {

            if (unsortedList.Count==0)
            {
                return -1;
            }
            int smallestValue = unsortedList[0];
            int smallestIndex = 0;
            for (int i = 0; i < unsortedList.Count; i++)
            {
                if (smallestValue > unsortedList[i])
                {
                    smallestValue = unsortedList[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }

        public static int FindLargest(List<int> unsortedList)
        {

            if (unsortedList.Count == 0)
            {
                return -1;
            }
            int largestValue = unsortedList[0];
            int largestIndex = 0;
            for (int i = 0; i < unsortedList.Count; i++)
            {
                if (largestValue < unsortedList[i])
                {
                    largestValue = unsortedList[i];
                    largestIndex = i;
                }
            }
            return largestIndex;
        }
    }
}
