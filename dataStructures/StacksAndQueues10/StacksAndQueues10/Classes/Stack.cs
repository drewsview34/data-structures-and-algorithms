using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues10.Classes
{
    public class Stack
    {
        public Node Top { get; set; }
        /// <summary>
        /// Creates A Stack With One Node
        /// </summary>
        /// <param name="node"></param>
        public Stack(Node node)
        {
            Top = node;
        }
        /// <summary>
        /// Creates An Empty Stack
        /// </summary>
        public Stack()
        {

        }
        /// <summary>
        /// Creates A New Node & Puts It At The Top Of The Stack
        /// </summary>
        /// <param name="value">(int value) For The Node</param>
        public void Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }
        /// <summary>
        /// Creates A Temp Node, Sets Top To The Next Node In The Stack, Clears The Reference Of Next On Temp, & Returns The Temp Node's Value.
        /// </summary>
        /// <returns>Popped Node's Value</returns>
        public int Pop()
        {
            Node temp = Top;
            Top = Top.Next;
            temp.Next = null;
            return temp.Value;
        }
        /// <summary>
        /// Shows The Value Of The Top Node On The Stack
        /// </summary>
        /// <returns>Top Node's Value</returns>
        public int Peek()
        {
            try
            {
                return Top.Value;
            }
            catch(Exception except)
            {
                throw new Exception(except.Message);
            }
        }
    }
}