using System;
using Xunit;
using linkedList07;


namespace linkedList07xUnit
{
    public class UnitTest1
    {
        [Fact]
        public void KFoundAtSecondFromEnd()
        {
            int kValue = Program.FindKthFromEnd(2);

            Assert.True(kValue == 7);
        }

        [Fact]
        public void KFoundAtEndOfList()
        {
            int kValue = Program.FindKthFromEnd(0);

            Assert.True(kValue == 9);
        }

        [Fact]
        public void KFoundAtHeadOfList()
        {
            int kValue = Program.FindKthFromEnd(9);

            Assert.True(kValue == 1);
        }
    }
}