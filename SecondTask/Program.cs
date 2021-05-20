using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] b = { 2, 5, 6, 8, 12, 42, 54, 12, 9 };

            int result = FindDublicate(b);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int FindDublicate(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        return arr[i];
                    }
                }
            }

            return 0;
        }
    }
}
