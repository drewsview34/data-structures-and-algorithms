using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues10.Classes
{
    public class Queue
    {
        /// <summary>
        /// Sets Front Node
        /// </summary>
        public Node Front { get; set; }
        /// <summary>
        /// Sets Rear Node
        /// </summary>
        public Node Rear { get; set; }
        /// <summary>
        /// Sets Front & Rear Nodes To Queue
        /// </summary>
        /// <param name="node">Takes In The Node</param>
        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }
        /// <summary>
        /// Enqueue Adds Node To The End & Sets Rear To The New Node
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(int value)
        {
            Node node = new Node(value);
            Rear.Next = node;
            Rear = node;
        }
        /// <summary>
        /// Dequeue removes node from front of queue
        /// </summary>
        /// <returns>a temp node</returns>
        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
                       
            return temp;
        }
        /// <summary>
        /// Peeks Is The Front Node
        /// </summary>
        /// <returns></returns>
        public Node Peek()
        {
            return Front;
        }
    }
}