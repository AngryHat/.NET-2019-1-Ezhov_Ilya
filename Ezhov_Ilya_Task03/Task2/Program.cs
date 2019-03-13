using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Program
    {
        public static Random random = new Random();

        static void Main(string[] args)
        {
            int[,,] array = new int[3, 3, 3];
            int minValue = -100;
            int maxValue = 100;
            Console.WriteLine($"This program generates threedimensional array[3,3,3] with random numbers between {minValue} and {maxValue}.");
            Console.WriteLine("After that program replaces all positive values with zero.\n");
            GenerateRandom3DArrayInt(array, minValue, maxValue);
            PositiveToZero3DArrayInt(array);
            Show3DArrayInt(array);

            Console.WriteLine("\n\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }

        public static void GenerateRandom3DArrayInt(int[,,] inputArray, int min, int max)
        {
            for (int x = 0; x < inputArray.GetLength(0); x++)
            {
                for (int y = 0; y < inputArray.GetLength(1); y++)
                {
                    for (int z = 0; z < inputArray.GetLength(2); z++)
                    {
                        inputArray[x, y, z] = random.Next(min, max);
                    }
                        
                }
            }
        }

        public static void Show3DArrayInt(int[,,] inputArray)
        {
            for (int x = 0; x < inputArray.GetLength(0); x++)
            {
                for (int y = 0; y < inputArray.GetLength(1); y++)
                {
                    for (int z = 0; z < inputArray.GetLength(2); z++)
                    {
                        Console.Write($"[{x},{y},{z}] = {inputArray[x, y, z]} \t");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        public static void PositiveToZero3DArrayInt(int[,,] inputArray)
        {
            for (int x = 0; x < inputArray.GetLength(0); x++)
            {
                for (int y = 0; y < inputArray.GetLength(1); y++)
                {
                    for (int z = 0; z < inputArray.GetLength(2); z++)
                    {
                        if (inputArray[x, y, z] > 0)
                        {
                            inputArray[x, y, z] = 0;
                        }
                    }
                }
            }
        }
    }
}
