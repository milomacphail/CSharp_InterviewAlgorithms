using static System.Console;
using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetValue = 43;

            int[] sampleArray = new int[] { 11, 23, 36, 43, 75, 81, 89 };

            WriteLine("Our array contains: ");
            Array.ForEach(sampleArray, x => Write(x + " "));

            Write($"\n\nThe result of the binary search for " + targetValue + " is: ");
            WriteLine(binarySearch(sampleArray, targetValue));
        }

        public static int binarySearch(int[] array, int target)
        {
            int firstIndex = 0;
            int lastIndex = array.Length - 1;

            while(firstIndex <= r)
            {
                int midpoint = (firstIndex + lastIndex) / 2;

                if (target < array[midpoint])
                {
                    lastIndex = midpoint - 1;
                }
                else if (target > array[midpoint])
                {
                    firstIndex = midpoint + 1;
                }
                else return midpoint;
            }
            return -1;
        }
    }
}
