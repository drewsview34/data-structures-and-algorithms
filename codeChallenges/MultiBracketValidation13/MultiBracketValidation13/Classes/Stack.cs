using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation13.Classes
{
    class Stack
    {
        /// <summary>
        /// Sets Reference of the Node to Top
        /// </summary>
        public Node Top { get; set; }


        /// <summary>
        /// Creates the stack with node(s)
        /// </summary>
        /// <param name="node"></param>
        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// Creates an empty stack
        /// </summary>
        public Stack()
        {

        }

        /// <summary>
        /// Pushes the top node
        /// </summary>
        /// <param name="value">Value of new node</param>
        public void Push(char value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Pops the top node
        /// </summary>
        /// <returns>temp node</returns>
        public Node Pop()
        {
            //temp
            Node temp = Top;
            //next node
            Top = Top.Next;
            // clear reference
            temp.Next = null;
            // return the node
            return temp;
        }

        /// <summary>
        /// Peeks at top node
        /// </summary>
        /// <returns>Top of Stack</returns>
        public Node Peek()
        {
            return Top;
        }
    }
}