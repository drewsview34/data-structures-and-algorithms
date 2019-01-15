using node;
using System;

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
        /// <summary>
        /// Appends a new node to the end of the linked list
        /// </summary>
        /// <param name="value"></param>
        public void Append(int value)
        {
            Current = Head;
            if (Head == null)
            {
                Insert(value);
                return;
            }
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Node node = new Node(value);
            Current.Next = node;
        }
        /// <summary>
        /// Inserts a new node before the target node after finding target node in linked list
        /// </summary>
        /// <param name="value">target value</param>
        /// <param name="newValue">new node value</param>
        public void InsertBefore(int value, int newValue)
        {
            Current = Head;
            if (Current.Value == value)
            {
                Insert(newValue);
                return;
            }
            while (Current.Next != null)
            {
                if (Current.Next.Value == value)
                {
                    Node node = new Node(newValue)
                    {
                        Next = Current.Next
                    };
                    Current.Next = node;
                    return;
                }
                else
                {
                    Current = Current.Next;
                }
            }
        }
        /// <summary>
        /// Inserts a new node after target node after finding target node in linked list
        /// </summary>
        /// <param name="value">target value</param>
        /// <param name="newValue">new node value</param>
        public void InsertAfter(int value, int newValue)
        {
            Current = Head;
            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    Node node = new Node(newValue)
                    {
                        Next = Current.Next
                    };
                    Current.Next = node;
                    return;
                }
                else
                {
                    Current = Current.Next;
                }
            }
            if (Current.Value == value)
            {
                Append(newValue);
                return;
            }
        }
    }
}
 