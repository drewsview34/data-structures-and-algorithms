using System;
using Xunit;
using _03;

namespace _03xUnit
{
    public class UnitTest1
    {
        //test whether or not the integer exists in the array
        [Fact]
        public void CanReturnNegativeOneTest()
        {
            int[] sortedArray = { 2, 4, 6, 8, 10, 11 };
            int searchKey = 3;
            Assert.Equal(-1, Program.BinarySearch(sortedArray, searchKey));
        }

        //test for output of integer index in the array
        [Theory]
        [InlineData(new int[] { 1, 12, 39, 40, 52, 60 }, 40, 3)]
        [InlineData(new int[] { 11, 22, 35, 44, 56, 65 }, 22, 1)]
        public void CanReturnIntegerIndexTest(int[] sortedArray, int searchKey, int expectedIndex)
        {
            Assert.Equal(expectedIndex, Program.BinarySearch(sortedArray, searchKey));
        }
    }
}