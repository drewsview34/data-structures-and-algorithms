using linkedList;
using System;

namespace linkedList06
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList newList = new LinkedList();

            try
            {
                int[] numbersInLinkedList = { 34, 5, 9999, 333, 411 };
                foreach (int number in numbersInLinkedList)
                {

                    newList.Insert(number);
                    Console.WriteLine($"{number} added to linked list.");
                }
                Console.WriteLine();

                Console.WriteLine($"Does 69 exist on the linked list?   {(newList.Includes(69) ? "Yes" : "No")}");
                Console.WriteLine($"Does 34 exist on the linked list?   {(newList.Includes(34) ? "Yes" : "No")}");
                Console.WriteLine($"Does 333 exist on the linked list?   {(newList.Includes(333) ? "Yes" : "No")}");
                Console.WriteLine();


                int[] insertTheseNumbersInLinkedList = { 8, 16, -3 };
                foreach (int number in insertTheseNumbersInLinkedList)
                {
                    newList.Insert(number);
                    Console.WriteLine($"{number} appended to linked list.");
                }
                Console.WriteLine();

                int[] numbersToBeInsertedBeforeNode = { 10, 20, 30 };
                int[] theNodesTheNumbersWillBeInsertedBefore = { 5, 411, 16 };
                for (int i = 0; i < numbersToBeInsertedBeforeNode.Length; i++)
                {
                    newList.InsertBefore(theNodesTheNumbersWillBeInsertedBefore[i], numbersToBeInsertedBeforeNode[i]);
                    Console.WriteLine($"{numbersToBeInsertedBeforeNode[i]} added to list before {theNodesTheNumbersWillBeInsertedBefore[i]}.");
                }
                Console.WriteLine();

                int[] numbersToBeInsertedAfterNode = { 15, 45, 60 };
                int[] theNodesTheNumbersWillBeInsertedAfter = { 9999, -3, 75 };
                for (int i = 0; i < numbersToBeInsertedBeforeNode.Length; i++)
                {
                    newList.InsertAfter(theNodesTheNumbersWillBeInsertedAfter[i], numbersToBeInsertedAfterNode[i]);
                    Console.WriteLine($"{numbersToBeInsertedAfterNode[i]} added to list after {theNodesTheNumbersWillBeInsertedAfter[i]}.");
                }
                Console.WriteLine();

                newList.Print();
                Console.WriteLine();
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                Console.WriteLine("End of test.");
                Console.ReadLine();
            }
        }
    }
}