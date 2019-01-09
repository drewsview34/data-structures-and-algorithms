using System;

namespace array_shift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 2, 4, 6, 8, 10, 11 };
            int addValue = 25;
            int[] outputArray = ArrayShift(inputArray, addValue);
            for (int i = 0; i < outputArray.Length; i++)
            {
                Console.WriteLine(outputArray[i]);
            }
        }

    }
}
