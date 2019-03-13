using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program outputs N strings with * symbols, where highest string is '*' and lowest is '*** ... N*'");
            Console.Write("Please enter N for output: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (n <= 0)
            {
                Console.WriteLine("N is negative or zero, output is incorrect.");
            }
            string output = "*";
            System.Console.WriteLine(output);
                for (int i = 1; i < n; i++)
            {
                output += "*";
                System.Console.WriteLine(output);
            }

            Console.WriteLine("\n\n\nEnd of program. Press any key.");
            System.Console.ReadKey();
        }
    }
}
