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
            CollectionAssert.AreEqual(expectedSortedList, AlgorithmsCore.SelectionSort.DoMinSelectionSort(unsortedList));

        }

        [TestMethod]
        public void TestQiuckSort()
        {
            List<int> unsortedList = new List<int>() { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            List<int> expectedSortedList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            CollectionAssert.AreEqual(expectedSortedList, AlgorithmsCore.QuickSort.DoQuickSort(unsortedList));

        }

        [TestMethod]
        public void TestBFS()
        {
            Dictionary<string, List<string>> graph = new Dictionary<string, List<string>>();
            graph.Add("startnode", new List<string>() { "alice", "bob", "claire" });
            graph.Add("alice", new List<string>() { "peggy" });
            graph.Add("bob", new List<string>() { "anuj", "peggy" });
            graph.Add("claire", new List<string>() { "thom Mango seller", "jonny" });
            graph.Add("anuj", null);
            graph.Add("peggy", null);
            graph.Add("thom  Mango seller", null);
            graph.Add("jonny", null);
            Assert.AreEqual("thom Mango seller", AlgorithmsCore.BreadthFirstSearch.DoBFS(graph));

        }
    }
}
