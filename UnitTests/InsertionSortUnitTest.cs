using SearchingAlgorithms;
using SearchingSortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class InsertionSortUnitTest
    {
        [Fact]
        public void TestSorted1()
        {
            var testItems = new[] { 4, 11, 8, 7, 10, 11 };
            Sort.InsertionSort(testItems);
            Assert.Equal([4, 7, 8, 10, 11, 11], testItems);
        }

        [Fact]
        public void TestSortedStaysSorted()
        {
            var testItems = new[] { 4, 7, 10, 11, 12 };
            Sort.InsertionSort(testItems);
            Assert.Equal([4, 7, 10, 11, 12], testItems);
        }

        [Fact]
        public void TestReversedIsSorted()
        {
            var testItems = new[] { 12, 11, 10, 7, 4 };
            Sort.InsertionSort(testItems);
            Assert.Equal([4, 7, 10, 11, 12], testItems);
        }

        [Fact]
        public void TestThreeItemsSuccess()
        {
            var testItems = new int[] { 6, 5, 7 };
            Sort.InsertionSort(testItems);
            Assert.Equal([5, 6, 7], testItems);
        }

        [Fact]
        public void TestTwoItemsSuccess()
        {
            var testItems = new int[] { 6, 5 };
            Sort.InsertionSort(testItems);
            Assert.Equal([5, 6], testItems);
        }

        [Fact]
        public void TestSingleItemSuccess()
        {
            var testItems = new int[] { 5 };
            Sort.InsertionSort(testItems);
            Assert.Equal([5], testItems);
        }

        [Fact]
        public void TestEmptySuccess()
        {
            var testItems = new int[0];
            Sort.InsertionSort(testItems);
            Assert.Equal([], testItems);
        }

        [Fact]
        public void TestNullSuccess()
        {
            Sort.InsertionSort(null);
        }
    }
}
