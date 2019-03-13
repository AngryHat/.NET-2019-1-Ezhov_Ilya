using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        public static int sum;
        static void Main(string[] args)
        {
            int start = 1;
            int end = 1000;
            int dividerA = 3;
            int dividerB = 5;
            Console.WriteLine($"This program outputs sum of all numbers between {start} and {end} that divisible by {dividerA} and {dividerB}.\n");
            for (int i = start; i < end; i++)
            {
                if (i % dividerA == 0)
                {
                    sum += i;
                }
                else if (i % dividerB == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"The sum of all numbers between {start} and {end} that divisible by {dividerA} and {dividerB} is: {sum}");

            Console.WriteLine("\n\n\nEnd of program. Press any key.");
            System.Console.ReadKey();
        }
    }
}
