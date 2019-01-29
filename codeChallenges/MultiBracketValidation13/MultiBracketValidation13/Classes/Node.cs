using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation13.Classes
{
    class Node
    {
        /// <summary>
        /// sets node value and next
        /// </summary>
        public char Value { get; set; }
        public Node Next { get; set; }

        public Node(char value)
        {
            Value = value;
        }
    }
}