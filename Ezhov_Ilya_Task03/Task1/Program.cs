using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        public static Random random = new Random();

        static void Main(string[] args)
        {
            int arrayMinSize = 10;
            int arrayMaxSize = 20;
            int minValue = 0;
            int maxValue = 1000;
            int[] array = new int[random.Next(arrayMinSize, arrayMaxSize)];
            Console.WriteLine($"This program generates array with random size between {arrayMinSize} and {arrayMaxSize} and fill it with random numbers between {minValue} and {maxValue}.\n");
            GenerateRandomArrayInt(array, minValue, maxValue);
            // ShowArrayInt(array);
            SortArrayInt(array);
            Console.WriteLine("Array has been sorted.\n");
            ShowMinMaxArraySortedInt(array);
            ShowArrayInt(array);

            Console.WriteLine("\n\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }

        public static void GenerateRandomArrayInt(int[] inputArray, int min, int max)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = random.Next(min, max);
            }
        }

        public static void ShowArrayInt(int[] inputArray)
        {
            Console.WriteLine($"Generated array contains {inputArray.Length} elements. Values of array:\n");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine($"[{i}] = {inputArray[i]}");
            }
            Console.WriteLine();
        }
        public static void ShowMinMaxArraySortedInt(int[] inputArray)
        {
            Console.WriteLine($"Maximal value of array is {inputArray[inputArray.Length - 1]}.");
            Console.WriteLine($"Minimal value of array is {inputArray[0]}.\n");
        }
            public static void ShowMinMaxArrayNotSortedInt(int[] inputArray)
        {
            int minValue = inputArray[0];
            int maxValue = inputArray[0];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (minValue > inputArray[i])
                {
                    minValue = inputArray[i];
                }
                if (maxValue < inputArray[i])
                {
                    maxValue = inputArray[i];
                }
            }
            Console.WriteLine($"Maximal value of array is {maxValue}.");
            Console.WriteLine($"Minimal value of array is {minValue}.\n");
        }

        public static void SortArrayInt(int[] inputArray)
        {
            int temp = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] > inputArray[j])
                    {
                        temp = inputArray[j];
                        inputArray[j] = inputArray[i];
                        inputArray[i] = temp;
                    }
                }
            }
        }
    }
}
