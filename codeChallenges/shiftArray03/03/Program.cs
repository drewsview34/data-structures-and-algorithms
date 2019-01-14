using System;

namespace _03
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArray = new int[] { 4, 8, 15, 16, 23, 42 };
            int searchKey = 15;
            Console.WriteLine(BinarySearch(sortedArray, searchKey));
        }

        public static int BinarySearch(int[] sortedArray, int searchKey)
        {
            //these variables will be used in conditional 
            int arrayMin = 0;
            int arrayMax = sortedArray.Length - 1;

            //loop through the binary array until the integer is hit OR reach end of array
            while (arrayMin <= arrayMax)
            {
                int midpoint = (arrayMin + arrayMax) / 2;
                //if the integer is greater than the midpoint value, run through the right side of the binary array
                if (sortedArray[midpoint] < searchKey)
                {
                    arrayMin = midpoint + 1;
                }
                //if the integer is less than the midpoint value, run through the left side of the binary array
                else if (sortedArray[midpoint] > searchKey)
                {
                    arrayMax = midpoint - 1;
                }
                //or if the integer matches the midpoint, return the index
                else
                {
                    return midpoint;
                }
            }
            return -1;
        }
    }
}