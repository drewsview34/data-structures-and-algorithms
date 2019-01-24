using QueueWithStacks11.Classes;
using Xunit;

namespace QueueWithStacks11xUnit
{
    public class UnitTest1
    {
        [Fact]
        public void EnqueueNodesPushToTop()
        {
            PseudoQueue test = new PseudoQueue();

            test.Enqueue(0);
            Assert.Equal(0, test.PseudoQ.Top.Value);
        }

        [Fact]
        public void TwoEnqueueNodesPushToTop()
        {
            PseudoQueue test = new PseudoQueue();

            test.Enqueue(0);
            test.Enqueue(1);
            Assert.Equal(1, test.PseudoQ.Top.Value);
        }

        [Fact]
        public void ThreeEnqueueNodesPushToTop()
        {
            PseudoQueue test = new PseudoQueue();

            test.Enqueue(0);
            test.Enqueue(1);
            test.Enqueue(2);
            Assert.Equal(2, test.PseudoQ.Top.Value);
        }

        [Fact]
        public void DequeueReturnsFrontNode()
        {
            PseudoQueue test = new PseudoQueue();
            test.Enqueue(22); // front <---result
            test.Enqueue(33);
            test.Enqueue(44);
            test.Enqueue(55); // rear

            int result = test.Dequeue();

            Assert.Equal(22, result);
        }

        [Fact]
        public void DoubleDequeue()
        {
            PseudoQueue test = new PseudoQueue();
            test.Enqueue(22); // front
            test.Enqueue(33); // <----result
            test.Enqueue(44);
            test.Enqueue(55); // rear

            test.Dequeue();
            int result = test.Dequeue();

            Assert.Equal(33, result);
        }

        [Fact]
        public void DequeuePutsBackOriginalOrder()
        {
            PseudoQueue test = new PseudoQueue();
            test.Enqueue(22);
            test.Enqueue(33);
            test.Enqueue(44);
            test.Enqueue(55);

            test.Dequeue();

            Assert.Equal(33, test.PseudoQ.Top.Next.Next.Value); // front
            Assert.Equal(44, test.PseudoQ.Top.Next.Value);
            Assert.Equal(55, test.PseudoQ.Top.Value); // rear
        }

        [Fact]
        public void DequeueSingleNodeStackToNull()
        {
            PseudoQueue test = new PseudoQueue();

            test.Enqueue(9999);

            Assert.Equal(9999, test.Dequeue());
            Assert.Null(test.PseudoQ.Top);
        }
    }
}