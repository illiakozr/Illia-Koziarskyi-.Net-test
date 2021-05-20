using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hours = FillHours();
            string[] minutes = FillMinutes();

            List<string> result = FindPolindrom(hours, minutes);

            foreach(string res in result)
            {
                Console.WriteLine(res);
            }

            Console.ReadLine();
        }

        // створюємо масив строк годин
        public static string[] FillHours()
        {
            string[] result = new string[25];

            for(int i = 0; i <= 9; i++)
            {
                result[i] = "0" + i.ToString();
            }

            for(int i = 10; i <= 24; i++)
            {
                result[i] = i.ToString();
            }

            return result;
        }

        // створюємо масив строк хвилин
        public static string[] FillMinutes()
        {
            string[] result = new string[61];

            for(int i = 0; i <= 9; i++)
            {
                result[i] = "0" + i.ToString();
            }

            for(int i = 10; i <= 60; i++)
            {
                result[i] = i.ToString();
            }

            return result;
        }

        // Шукаємо поліндроми строк
        public static List<string> FindPolindrom(string[] hours, string[] minutes)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < hours.Length; i++)
            {
                for(int j = 0; j < minutes.Length; j++)
                {
                    if (hours[i] == minutes[j].ReverseString())
                    {
                        result.Add(hours[i] + ":" + minutes[j]);
                    }
                }
            }

            return result;
        }
    }

    // Extension метод для реверсу нашої строки 
    public static class StringExtension
    {
        public static string ReverseString(this string input)
        {
            StringBuilder output = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                output.Append(input[i]);               
            }

            return output.ToString();
        }
    }
    
}
