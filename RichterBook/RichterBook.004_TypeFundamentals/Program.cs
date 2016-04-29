using System;
using System.Collections.Generic;

namespace RichterBook._004_TypeFundamentals
{
    class Program
    {
        static void Main()
        {
            int[] ints = { 1, 4, 56, 345, 44 };
            double[] doubles = { 1.0, 3.4, 4.98 };
            string[] strings = { "a", "f", "b", "c" };

            Console.WriteLine(Searcher.Search(ints, 345)); // 3
            Console.WriteLine(Searcher.Search(doubles, 3.4)); // 1
            Console.WriteLine(Searcher.Search(strings, "f")); // 1
            
            Console.ReadLine();
        }   
    }

    internal static class Searcher
    {
        public static int Search<T>(T[] arr, T element)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(arr[i], element))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
