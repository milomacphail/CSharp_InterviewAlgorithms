using static System.Console;
using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 7;
            int[] sampleArray = new[] { 1, 3, 5, 7, 9, 11 };

            System.Console.WriteLine("Our array contains:  ");
            Array.ForEach(sampleArray, x => Write(x + " "));

            Write($"\n\nThe result of the linear search for " + value + " is ");
            WriteLine(linearSearch(sampleArray, value) + ".");
        }

        static int linearSearch(int[] array, int targetValue)
        { 
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == targetValue)
                {
                   return i;
                }
            }

            return -1;
        }
    }
}
