using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            Assert.AreEqual(expectedIndex, Algorithms.BinarySearch.DoBinarySearch(sortedArray, randomValue));

        }
    }
}
