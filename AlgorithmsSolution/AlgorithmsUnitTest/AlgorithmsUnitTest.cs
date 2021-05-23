using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AlgorithmsUnitTest
{
    [TestClass]
    public class AlgorithmsUnitTest
    {
        [TestMethod]
        public void TestBinarySearch()
        {
            int[] sortedArray = new int[1024];
            int randomValue = new Random().Next(sortedArray.Length);
            int expectedIndex = randomValue;
            for (int i = 0; i < sortedArray.Length; i++)
            {
                sortedArray[i] = i;
            }
            Assert.AreEqual(expectedIndex, AlgorithmsCore.BinarySearch.DoBinarySearch(sortedArray, randomValue));

        }

        [TestMethod]
        public void TestSelectionSort()
        {
            List<int> unsortedList = new List<int>() { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            List<int> expectedSortedList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            CollectionAssert.AreEqual(expectedSortedList, AlgorithmsCore.Selection_Sort.DoMinSelectionSort(unsortedList));

        }
    }
}
