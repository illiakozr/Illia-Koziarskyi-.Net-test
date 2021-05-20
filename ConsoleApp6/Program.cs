using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    

    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2,4,8,34};
            int[] b = { 2, 5, 6, 8, 12, 42, 54 };
            int[] res = SortTwoArray(a,b);

            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }

            Console.Read();
        }

        static int[] SortTwoArray(int[] a, int[] b)
        {
            int[] result = new int[a.Length + b.Length];

            int length1 = a.Length;

            // заносимо перший масив в результуючий масив
            for(int i = 0; i < a.Length; i++)
            {
                result[i] = a[i];
            }

            // заносимо другий масив в результуючий масив
            for (int i = 0; i < b.Length; i++)
            {
                result[length1 + i] = b[i];
            }

            // сортировка бульбашкою
            int temp;
            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }

            return result;
        }
    }

    
}
