using StacksAndQueues10.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks11.Classes
{
    public class PseudoQueue
    {
        public Stack PseudoQ { get; set; }
        // Pseudo Queue cCnstructor Creates A New Stack Instance In PseudoQueue
        public PseudoQueue()
        {
            PseudoQ = new Stack();
        }
        // Stack Push() Method Works The Same As Enqueue() By Simply Adding A New Node To The Rear Which Is Equal To Top
        public void Enqueue(int value)
        {
            PseudoQ.Push(value);
        }
        // Simulates Dequeue() By Popping All But The Last Node And Pushing Into A Temp Stack, Pushing It All Again To A New Stack, Then Reassigning It Back To The PseudoQueue Stack.
        public int Dequeue()
        {
            // Temp Stacks For Flipping and Popping
            Stack StackOne = new Stack();
            Stack StackTwo = new Stack();
            int temp;
            // If PsuedoQ Only Has One Node, Pop It And Return Its Value.
            if (PseudoQ.Top.Next == null)
            {
                temp = PseudoQ.Pop();
                return temp;
            }
            // Moves All But The Dequeued Node To Temp StackOne
            while (PseudoQ.Top.Next != null)
            {
                StackOne.Push(PseudoQ.Pop());
            }
            // Stores The Value Of The Dequeued Node
            temp = PseudoQ.Top.Value;
            // Moves All The Nodes From StackOne To stackTwo In Original Order
            while (StackOne.Top.Next != null)
            {
                StackTwo.Push(StackOne.Pop());
            }
            if (StackOne.Top.Next == null)
            {
                StackTwo.Push(StackOne.Pop());
            }
            // Assigns The New Stack Minus The Dequeued Node Back To PsuedoQ
            PseudoQ = StackTwo;
            // Returns Dequeued Node's Value
            return temp;
        }
    }
}