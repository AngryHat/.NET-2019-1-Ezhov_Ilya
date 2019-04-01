using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public delegate int del(string str1, string str2);
        public static del myDel;

        static void Main(string[] args)
        {
            string[] input = { "abbaaaa", "ccc", "a", "aba", "ab", "caabaa", "abb", "aaaabaa", "ac", "b", "abaaaba", "c", "caabba", "aaabba", "aa" };

            Console.WriteLine("This program sort array of strings and uses delegate to compare strings." +
                $"\n\nOriginal arrays is: ");
            int count = 0;
            foreach (var item in input)
            {
                Console.WriteLine($"[{count}] = {item}");
                count++;
            }
            Console.WriteLine("\n\n");

            SortArray(input);


            Console.WriteLine("Sorted arrays is: ");
            count = 0;
            foreach (var item in input)
            {
                Console.WriteLine($"[{count}] = {item}");
                count++;
            }
            Console.WriteLine("\n\n");

            Console.ReadKey();
        }

        public static void SortArray(string[] stringArray)
        {
            for (int i = 0; i < stringArray.Length; i++)
            {
                for (int j = i; j < stringArray.Length; j++)
                {
                    myDel = new del(CompareStrings);
                    if (myDel(stringArray[i], stringArray[j]) == 1)
                    {
                        SwithElements(stringArray, i, j);
                    }
                    if (myDel(stringArray[i], stringArray[j]) == 2)
                    {
                        SwithElements(stringArray, i, j);
                    }
                }
            }
        }
        //public static bool CompareStringsByLength(string str1, string str2)
        //{
        //    if (str1.Length > str2.Length)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public static bool CompareStringsByAlphabet(string str1, string str2)
        //{
        //    if (str1.Length == str2.Length && string.Compare(str1, str2) == 1)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        public static void SwithElements(string[] arr, int index, int index2)
        {
            string temp = arr[index2];
            arr[index2] = arr[index];
            arr[index] = temp;
        }
        public static int CompareStrings(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return 1;
            }
            if (str1.Length == str2.Length && string.Compare(str1, str2) == 1)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
