using linkedList;
using System;
using Xunit;

namespace linkedList05xUnit
{
    public class UnitTest1
    {
        // Tests That Property Setters Are Correct With The Insert() Method Property
        [Fact]
        public void NodeValueIsEight()
        {
            LinkedList testList = new LinkedList();
            testList.Insert(8);
            Assert.True(testList.Head.Value == 8);
        }

        [Fact]
        public void LastInsertIsHead()
        {
            LinkedList testList = new LinkedList();
            testList.Insert(4);
            testList.Insert(2);
            bool isHead = testList.Head.Value == 2;
            Assert.True(isHead);
        }

        [Fact]
        public void NodeHasNoCurrent()
        {
            LinkedList testList = new LinkedList();
            testList.Insert(1);
            bool current = testList.Current == null;
            Assert.True(current);
        }
        // Test To Detect If A Given Value Is Detected With The Includes() Method Property

        [Fact]
        public void ValueIsInList()
        {
            LinkedList testList = new LinkedList();
            testList.Insert(5);
            testList.Insert(6);
            testList.Insert(7);
            testList.Insert(8);
            bool isFound = testList.Includes(7);
            Assert.True(isFound);
        }

        [Fact]
        public void ValueNotInList()
        {
            LinkedList testList = new LinkedList();
            testList.Insert(1);
            testList.Insert(2);
            testList.Insert(3);
            testList.Insert(4);
            bool isFound = testList.Includes(8);
            Assert.False(isFound);
        }
    }
}