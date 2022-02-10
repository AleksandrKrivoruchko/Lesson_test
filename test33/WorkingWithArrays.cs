using System;
using static System.Console;

namespace OneDimensionalArrays
{
    internal class WorkingWithArrays
    {
        public static int[] CreateArray(int len, int rangeMin, int rangeMax )
        {
            int[] resultArray = new int[len];
            Random rnd = new();
            for(int i = 0; i < len; i++)
            {
                resultArray[i] = rnd.Next(rangeMin, rangeMax + 1);
            }
            return resultArray;
        }

        public static void PrintArray(int[] array)
        {
            int k = 0;
            for(int i = 0; i < array.Length; i++)
            {
                Write($"{array[i]}\t");
                k++;
                if(k == 10)
                {
                    WriteLine();
                    k = 0;
                }
            }
            WriteLine();
        }

        public static int SumPositiveElements(int[] array)
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] > 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        public static int SumNegativeEkements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}
