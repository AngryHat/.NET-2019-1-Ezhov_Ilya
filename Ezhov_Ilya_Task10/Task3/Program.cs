using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Task3.Program;

namespace Task3
{
    class Event
    {
        public delegate void SortingDone();
        private event SortingDone SortingDoneEvent;

        public Event()
        {
            SortingDoneEvent += EndSignal;
        }

        public void EndThread()
        {
            SortingDoneEvent?.Invoke();
        }

        private static void EndSignal()
        {
            Console.WriteLine("!!! Sorting is done in own thread.\n");
        }
    }

    class Program
    {
        public delegate bool compareDelegate(string str1, string str2);
        public static compareDelegate compareDel;

        

        static void Main(string[] args)
        {
            string[] input = { "abbaaaa", "ccc", "a", "aba", "ab", "caabaa", "abb", "aaaabaa", "ac", "b", "abaaaba", "c", "caabba", "aaabba", "aa" };
            object inputObj = input;


            Console.WriteLine("This program sort array of strings and uses delegate to compare strings." +
                "\nAlso sorting executing in it's own thread." +
                $"\n\nOriginal arrays is:\n");
            ShowArray(input);
            SortArrayNewThread(inputObj);
            Console.WriteLine("Sorted array is:\n");
            ShowArray(input);


            Console.WriteLine("End of program. Press any key.");
            Console.ReadKey();
        }

        public static void SortArray(object sortingObject)
        {
            string[] stringArray = (string[])sortingObject;

            for (int i = 0; i < stringArray.Length; i++)
            {
                for (int j = i; j < stringArray.Length; j++)
                {
                    compareDel = new compareDelegate(CompareStrings);
                    bool result = compareDel(stringArray[i], stringArray[j]);
                    if (result)
                    {
                        SwapElements(stringArray, i, j);
                    }
                }
            }
        }

        public static void SortArrayNewThread(object sortingObject)
        {
            string[] stringArray = (string[])sortingObject;

            Thread thread = new Thread(new ParameterizedThreadStart(SortArray));
            thread.Start(stringArray);
            SortArray(stringArray);

            Event @event = new Event(); //events added
            while (true)
            {
                if (!thread.IsAlive)
                {
                    @event.EndThread();
                    return;
                }
            }
        }

        public static void SwapElements(string[] arr, int index, int index2)
        {
            string temp = arr[index2];
            arr[index2] = arr[index];
            arr[index] = temp;
        }
        public static bool CompareStrings(string str1, string str2)
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

        public static void ShowArray(string[] input)
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
