using System;

namespace insertShiftArrayMidIndex
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] inArray = new int[] { 2, 4, 6, 8, 10, 11 };
            int addNum = 25;
            //call in the parameters for external method
            int[] outArray = ArrayShift(inArray, addNum);
            for (int i = 0; i < outArray.Length; i++)
            {
                Console.WriteLine(outArray[i]);
            }
        }

        static int[] ArrayShift(int[] inArray, int addNum)
        {
            //set length of the new array
            int[] outArray = new int[inArray.Length + 1];

            //loop through the first half of the array
            for (int i = 0; i < inArray.Length / 2; i++)
            {
                //assign indeces from input to output
                outArray[i] = inArray[i];
            }

            //insert the additional value after the midpoint
            outArray[inArray.Length / 2] = addNum ;

            //loop through the second half of the array
            for (int i = inArray.Length/2 + 1; i < outArray.Length; i++)
            {
                //assign indeces from input to output, after the midpoint
                outArray[i] = inArray[i-1];
            }
            return outArray;
        }
    }
}