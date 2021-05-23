using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class BinarySearch
    {
        public static int DoBinarySearch(int[] sortedArray, int searchValue) {
            int low = 0;
            int high = sortedArray.Length - 1;
            int mid = 0;
            int guess = 0;
            while (low<=high)
            {
                mid = low + high;
                guess = sortedArray[mid];
                if (guess == searchValue)
                {
                    return mid;
                }
                if (guess>searchValue)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
    }
}
