using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Program
    {
        public static Random random = new Random();

        static void Main(string[] args)
        {
            int arrayMinSize = 10;
            int arrayMaxSize = 20;
            int minValue = -100;
            int maxValue = 100;
            int[] array = new int[random.Next(arrayMinSize, arrayMaxSize)];
            Console.WriteLine($"This program generates array with random size between {arrayMinSize} and {arrayMaxSize} and fill it with random numbers between {minValue} and {maxValue}.");
            Console.WriteLine("After that program sums all nonnegative values of array.\n");
            Task1.Program.GenerateRandomArrayInt(array, minValue, maxValue);
            Task1.Program.ShowArrayInt(array);
            Console.WriteLine($"Sum of all nonnegative numbers is {SumNonnegativeValuesOfArray(array)}.");

            Console.WriteLine("\n\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }

        public static int SumNonnegativeValuesOfArray(int[] inputArray)
        {
            int sum = 0;
            foreach (var element in inputArray)
            {
                if (element >= 0)
                {
                    sum += element;
                }
            }
            return sum;
        }
    }
}
