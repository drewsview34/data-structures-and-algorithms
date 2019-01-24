using StacksAndQueues10.Classes;

namespace QueueWithStacks11.Classes
{
    public class PseudoQueue
    {
        public Stack PseudoQ { get; set; }

        // Pseudo queue constructor creates new Stack instance in PseudoQueue
        public PseudoQueue()
        {
            PseudoQ = new Stack();
        }

        // Stack push() method works the same as Enqueue() by simply adding a new node to the rear which is equal to top
        public void Enqueue(int value)
        {
            PseudoQ.Push(value);
        }

        // Simulates Dequeue() by popping all but the last node and pushing into a temp stack, pushing it all again to a new stack, then reassigning it back to the PseudoQueue stack.
        public int Dequeue()
        {
            // Temp stacks for flipping and popping
            Stack StackOne = new Stack();
            Stack StackTwo = new Stack();
            int temp;

            // If PQueue only has one node, pop it and return its value.
            if (PseudoQ.Top.Next == null)
            {
                temp = PseudoQ.Pop();
                return temp;
            }

            // Moves all but the dequeued node to temp stack1
            while (PseudoQ.Top.Next != null)
            {
                StackOne.Push(PseudoQ.Pop());
            }

            // Stores the value of the dequeued node
            temp = PseudoQ.Top.Value;

            // Moves all the nodes from stack1 to stack2 in original order
            while (StackOne.Top.Next != null)
            {
                StackTwo.Push(StackOne.Pop());

            }
            if (StackOne.Top.Next == null)
            {
                StackTwo.Push(StackOne.Pop());
            }

            // Assigns the new stack minus the dequeued node back to PQueue
            PseudoQ = StackTwo;
            // Returns dequeued node's value
            return temp;
        }
    }
}