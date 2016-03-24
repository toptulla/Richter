using System;

namespace RichterBook._016_Arrays
{
    class Program
    {
        private static void Main()
        {
            Console.ReadLine();
        }

        private static void MultidimensionalArray()
        {
            int[,] a = new int[10, 2];

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 2; j++)
                    a[i, j] = 1;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write("{0}\t", a[i, j]);
                Console.WriteLine();
            }
        }

        private static void InitElementArray()
        {
            // Чудеса компилятора
            string[] s = new string[] { "a" };
            string[] s1 = new[] { "a" };
            var s2 = new[] { "a" };
            string[] s3 = { "a" };
            var anonymouseArr = new[] { new { Name = "Bob" }, new { Name = "Alice" } };
        }
    }
}
