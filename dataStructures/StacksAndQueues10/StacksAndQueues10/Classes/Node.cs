using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues10.Classes
{
    /// <summary>
    /// Creates Node
    /// </summary>
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}