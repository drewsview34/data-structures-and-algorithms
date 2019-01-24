using QueueWithStacks11.Classes;
using System;

namespace QueueWithStacks11
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                QueueWithStacks();
            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
        }

        public static void QueueWithStacks()
        {
            PseudoQueue pseudoQue = new PseudoQueue();
            pseudoQue.Enqueue(5);
            pseudoQue.Enqueue(10);
            pseudoQue.Enqueue(15);
            pseudoQue.Enqueue(20);


            Console.WriteLine(pseudoQue.PseudoQ.Top.Next.Next.Value);

            Console.WriteLine(pseudoQue.Dequeue());

            Console.WriteLine(pseudoQue.PseudoQ.Top.Next.Next.Value);
        }
    }
}