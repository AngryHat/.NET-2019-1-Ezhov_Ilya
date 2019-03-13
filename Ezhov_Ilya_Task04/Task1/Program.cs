using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program reads input text from console, then calculates average length of words in entered text.");
            Console.Write("Please enter some text:");
            string inputString = Console.ReadLine();
            char[] separatingChars = { ' ', ',', '.', '!', '?' };
            string[] separatedString = SeparateString(inputString, separatingChars);
            double averageLength = CalcAverageLength(separatedString);
            Console.WriteLine($"\nAverage length of words in entered text is: {averageLength:0.##2} chars.");

            Console.WriteLine("\n\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }

        static string[] SeparateString(string input, char[] separators)
        {
            string[] result = input.Split(separators, System.StringSplitOptions.RemoveEmptyEntries);
            return result;
        }
        static double CalcAverageLength(string[] input)
        {
            int i;
            int sum = 0;
            for (i = 0; i < input.Length; i++)
            {
                sum += input[i].Length;
            }
            double result = Convert.ToDouble(sum) / i;
            return result;
        }
    }
}
