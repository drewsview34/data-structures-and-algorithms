using linkedList;
using System;

namespace linkedList07
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int k = 7;
                int kValue = FindKthFromEnd(k);
                Console.WriteLine($"Node value {k} is placed after the {kValue} node from the end of the list");
            }
            catch (Exception except)
            {
                throw new Exception(except.Message);
            }
        }

        /// <summary>
        /// This Method Takes In An Argument (Int K) and returns the value of the node traversing from the end of the linked list.
        /// </summary>
        /// <param name="k">number of places from end</param>
        /// <returns></returns>
        public static int FindKthFromEnd(int k)
        {
            LinkedList theList = new LinkedList();
            Console.Write("Linked List Values: ");
            for (int index = 9; index > 0; index--)
            {
                theList.Insert(index);
            }

            int theListLength = 0;

            // Loops through entire list to measure its length
            theList.Current = theList.Head;
            while (theList.Current.Next != null)
            {
                Console.Write($"[{theList.Current.Value}] ");
                theList.Current = theList.Current.Next;
                theListLength++;
            }
            if (theList.Current.Next == null)
            {
                Console.WriteLine($"[{theList.Current.Value}] ");
                theListLength++;
            }
            //Loops Through Entire List Again, Then Returns the Value Of The Node.
            theList.Current = theList.Head;
            for (int index = 0; index < theListLength - k - 1; index++)
            {
                theList.Current = theList.Current.Next;
            }
            return theList.Current.Value;
        }
    }
}