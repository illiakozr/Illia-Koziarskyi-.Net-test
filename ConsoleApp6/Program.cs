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

            int i = 0; // індекс масиву а
            int j = 0; // індекс масиву b
            int k = 0; // індекс результуючого масиву

            while(i < a.Length || j < b.Length)
            {
                if(i < a.Length && j < b.Length)
                {
                    if(a[i] < b[j])
                    {
                        result[k] = a[i];
                        i++;
                        k++;
                    }
                    else
                    {
                        result[k] = b[j];
                        j++;
                        k++;
                    }
                }
                // якщо дойшли до кінця першого масиву, то заносимо решту другого в результуючий
                else if (i == a.Length)  
                {
                    result[k] = b[j];
                    j++;
                    k++;
                }
                // якщо дойшли до кінця другого масиву, то заносимо решту першого в результуючий
                else if (j == b.Length)
                {
                    result[k] = b[i];
                    i++;
                    k++;
                }
            }

            return result;
        }
    }

    
}
