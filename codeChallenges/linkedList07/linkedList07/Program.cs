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
                Console.WriteLine($"Node value {k} placed at the end of the list is {kValue}");
            }
            catch (Exception except)
            {
                throw new Exception(except.Message);
            }
        }

        /// <summary>
        /// Takes an argument of an integer a returns the value of the node which is that many places from the end of the linked list.
        /// </summary>
        /// <param name="k">number of places from end</param>
        /// <returns></returns>
        public static int FindKthFromEnd(int k)
        {
            LinkedList theList = new LinkedList();
            Console.Write("Node list values: ");
            for (int i = 9; i > 0; i--)
            {
                theList.Insert(i);
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

            // Loops again up to the length - k - 1 then stops and returns the node value
            theList.Current = theList.Head;
            for (int i = 0; i < theListLength - k - 1; i++)
            {
                theList.Current = theList.Current.Next;
            }
            return theList.Current.Value;
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}