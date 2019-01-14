using System;
using linkedList.classes;

    namespace linkedList
    {
        public class linkedList
        {
            static void Main(string[] args)
            {
                linkedList newList = new linkedList();

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
                }
            }
        }
    }