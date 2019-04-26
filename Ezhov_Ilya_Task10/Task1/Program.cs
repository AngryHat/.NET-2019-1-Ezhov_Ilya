using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    public class SortDirection
    {
        public static bool Ascending(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return true;
            }
            if (str1.Length == str2.Length && string.Compare(str1, str2) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Descending(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return true;
            }
            if (str1.Length == str2.Length && string.Compare(str2, str1) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        public delegate bool del(string str1, string str2);
        public static del orderDelegate;

        static void Main(string[] args)
        {
            string[] input = { "abbaaaa", "ccc", "a", "aba", "ab", "caabaa", "abb", "aaaabaa", "ac", "b", "abaaaba", "c", "caabba", "aaabba", "aa" };

            Console.WriteLine("This program sort array of strings and uses delegate to compare strings.\n\n" +
                $"Original arrays is:\n");

            ShowArray(input);
            orderDelegate = new del(SortDirection.Ascending);
            Console.WriteLine("Sorted array is:\n");
            SortArray(input);
            ShowArray(input);

            Console.WriteLine("End of program. Press any key.");
            Console.ReadKey();
        }

        public static void SortArray(string[] stringArray)
        {
            
            for (int i = 0; i < stringArray.Length; i++)
            {
                for (int j = i; j < stringArray.Length; j++)
                {
                    if (orderDelegate(stringArray[i], stringArray[j]))
                    {
                        SwapElements(stringArray, i, j);
                    }
                }
            }
        }

        public static void SwapElements(string[] arr, int index, int index2)
        {
            string temp = arr[index2];
            arr[index2] = arr[index];
            arr[index] = temp;
        }
        public static void ShowArray(object[] input)
        {
            int count = 0;
            foreach (var item in input)
            {
                Console.WriteLine($"[{count}] = {item}");
                count++;
            }
            Console.WriteLine("\n\n");
        }
    }
}

