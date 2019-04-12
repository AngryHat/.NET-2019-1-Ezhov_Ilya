using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    // ПЕРЕДЕЛАТЬ ЧЕРЕЗ ИВЕНТ
    class Program
    {
        public delegate int delegateSimple(string str1, string str2);
        public static delegateSimple myDelegate;
        public delegate void delegateThread();
        public static delegateThread myDelThread;

        public static string[] inputThread;
        public static bool ThreadSoryingDone = false;

        static void Main(string[] args)
        {
            string[] input = { "abbaaaa", "ccc", "a", "aba", "ab", "caabaa", "abb", "aaaabaa", "ac", "b", "abaaaba", "c", "caabba", "aaabba", "aa" };
            inputThread = input;
            myDelThread = SortArrayThread;
            

            Console.WriteLine("This program sort array of strings and uses delegate to compare strings." +
                "\nAlso sorting executing in it's own thread." +
                $"\n\nOriginal arrays is: ");
            int count = 0;
            foreach (var item in input)
            {
                Console.WriteLine($"[{count}] = {item}");
                count++;
            }
            Console.WriteLine("\n\n");
            
            StartSortingThread();
            while (!ThreadSoryingDone)
            {
                Thread.Sleep(50);
            }

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
                    myDelegate = new delegateSimple(CompareStrings);
                    if (myDelegate(stringArray[i], stringArray[j]) == 1)
                    {
                        SwapElements(stringArray, i, j);
                    }
                    if (myDelegate(stringArray[i], stringArray[j]) == 2)
                    {
                        SwapElements(stringArray, i, j);
                    }
                }
            }
        }

        public static void StartSortingThread()
        {
            Thread thread = new Thread(new ThreadStart(SortArrayThread));
            thread.Start();
        }
        public static void SortArrayThread()
        {
            Console.WriteLine("Sorting thread started.");
            SortArray(inputThread);
            ThreadSoryingDone = true;
            Console.WriteLine("Sorting thread ended.");

        }
        
        public static void SwapElements(string[] arr, int index, int index2)
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
