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
                int[] numbers = { 34, 5, 9999, 333, 411 };
                foreach (int number in numbers)
                {

                    newList.Insert(number);
                    Console.WriteLine($"{number} added to linked list.");
                }
                Console.WriteLine();

                Console.WriteLine($"Does 69 exist on the linked list?   {(newList.Includes(69) ? "Yes" : "No")}");
                Console.WriteLine($"Does 34 exist on the linked list?   {(newList.Includes(34) ? "Yes" : "No")}");
                Console.WriteLine($"Does 333 exist on the linked list?   {(newList.Includes(333) ? "Yes" : "No")}");
                Console.WriteLine();


                int[] moarNums = { 8, 16, -3 };
                foreach (int num in moarNums)
                {
                    newList.Insert(num);
                    Console.WriteLine($"{num} appended to linked list.");
                }
                Console.WriteLine();

                int[] manyNums = { 25, 50, 75 };
                int[] manyNumsTarget = { 5, 911, 16 };
                for (int i = 0; i < manyNums.Length; i++)
                {
                    newList.InsertBefore(manyNumsTarget[i], manyNums[i]);
                    Console.WriteLine($"{manyNums[i]} added to list before {manyNumsTarget[i]}.");
                }
                Console.WriteLine();

                int[] suchNums = { 15, 45, 60 };
                int[] suchNumsTarget = { 9999, -3, 75 };
                for (int i = 0; i < manyNums.Length; i++)
                {
                    newList.InsertAfter(suchNumsTarget[i], suchNums[i]);
                    Console.WriteLine($"{suchNums[i]} added to list after {suchNumsTarget[i]}.");
                }
                Console.WriteLine();

                newList.Print();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("End of test.");
            }
        }
    }
}