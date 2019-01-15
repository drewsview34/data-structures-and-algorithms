using node;
using System;
using linkedLists;

namespace linkedList
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }
        /// <summary>
        /// Creates A new Node Instance
        /// </summary>
        /// <param name="value"></param>
        /// 
        public void Insert(int value)
        {
            try
            {
                Node node1 = new Node(value);
                Node node = node1;
                node.Next = Head;
                Head = node1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Determines If Value Exists
        /// </summary>
        /// <param name="value">Node Value</param>
        /// <returns>true or false</returns>
        public bool Includes(int value)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return true;
                }
                Current = Current.Next;
            }
            if (Current.Value == value)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Prints All Values To The Console.
        /// </summary>
        public void Print()
        {
            Current = Head;
            Console.Write("Values of linked list: ");
            while (Current.Next != null)
            {
                Console.Write($"{Current.Value}, ");
                Current = Current.Next;
            }
            Console.WriteLine($"{Current.Value}");
        }
    }
}