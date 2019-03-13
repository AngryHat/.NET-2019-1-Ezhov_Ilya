using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        public static Random random = new Random();

        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            int minValue = 0;
            int maxValue = 10;
            Console.WriteLine($"This program generates twodimensional array[5,5] with random numbers between {minValue} and {maxValue}.");
            Console.WriteLine("After that program finds sum of all the elements on even* positions of the arary.");
            Console.WriteLine("* - even position means that sum of two indexes of element is even ([1,1], [1,3], [2,4] etc.)\n");
            GenerateRandom2DArrayInt(array, minValue, maxValue);
            Show2DArrayInt(array);
            Console.WriteLine($"Sum of all elements on even positions is: {SumEvenPosElements(array)}");

            Console.WriteLine("\n\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }

        public static void GenerateRandom2DArrayInt(int[,] inputArray, int min, int max)
        {
            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                for (int j = 0; j < inputArray.GetLength(1); j++)
                {
                    inputArray[i, j] = random.Next(min, max);
                }
            }
        }

        public static void Show2DArrayInt(int[,] inputArray)
        {
            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                for (int j = 0; j < inputArray.GetLength(1); j++)
                {
                    Console.Write($"[{i},{j}] = {inputArray[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int SumEvenPosElements(int[,] inputArray)
        {
            int evenPosSum = 0;
            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                for (int j = 0; j < inputArray.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        evenPosSum += inputArray[i, j];
                    }
                }
            }
            return evenPosSum;
        }
    }
}
