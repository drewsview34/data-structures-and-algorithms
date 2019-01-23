using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues10.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }
        /// <summary>
        /// Creates A Queue With One Node
        /// </summary>
        /// <param name="node">Node's Object</param>
        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }
        /// <summary>
        /// Creates A New Node & Sets It At The End Of The Queue
        /// </summary>
        /// <param name="value">value for new node</param>
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            Rear.Next = node;
            Rear = node;
        }
        /// <summary>
        /// Removes The Node At The Front Of The Queue & Returns Its Value
        /// </summary>
        /// <returns>Removed Front Node's Value</returns>
        public int Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp.Value;
        }
        /// <summary>
        /// Removes The Node At The Front Of The Queue & Returns Its Value
        /// </summary>
        /// <returns>The Front Node's Value</returns>
        public int Peek()
        {
            try
            {
                return Front.Value;
            }
            catch (Exception except)
            {
                throw new Exception(except.Message);
            }
        }
    }
}