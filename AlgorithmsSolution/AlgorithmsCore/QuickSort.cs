using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCore
{
    public static class QuickSort
    {
        private static int GetPivot(List<int> unsortedList) {
            var medianValue = (SelectionSort.FindLargest(unsortedList)+ SelectionSort.FindSmallest(unsortedList))/2;
            var pivotIndex = 0;
            var smalestDiff = int.MaxValue;
            for (int i = 0; i < unsortedList.Count; i++)
            {
                if (smalestDiff > Math.Abs(unsortedList[i] - medianValue))
                {
                    smalestDiff = Math.Abs(unsortedList[i] - medianValue);
                    pivotIndex = i;
                }
            }
            return pivotIndex;
        }

        public static List<int> DoQuickSort(List<int> unsortedList) {
            if (unsortedList.Count < 2)
            {
                return unsortedList;
            }
            else {
                var pivot = unsortedList[GetPivot(unsortedList)];
                List<int> less = unsortedList.Where(x => x < pivot).ToList();
                List<int> greater = unsortedList.Where(x => x > pivot).ToList();

                List<int> result = new List<int>();
                result.AddRange(DoQuickSort(less));
                result.Add(pivot);
                result.AddRange(DoQuickSort(greater));
                return  result;
            }
        
        }

    }
}
