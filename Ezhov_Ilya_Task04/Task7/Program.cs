using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(0[0-9]|1[0-9]|2[0-3]|[0-9]):[0-5][0-9]";

            Console.WriteLine("This program shows how many times time(hh:mm or h:mm) occurs in the text.");
            Console.Write("Enter your text: ");
            string input = Console.ReadLine();
            int result = 0;
            foreach (Match m in Regex.Matches(input, pattern))
            {
                result++;
            }
            if (result == 0)
            {
                Console.WriteLine($"\nTime not occurs in the text.");
            }
            if (result == 1)
            {
                Console.WriteLine($"\nTime occurs in the text once.");
            }
            else
            {
                Console.WriteLine($"\nTime occurs in the text {result} times.");
            }


            Console.WriteLine("\n\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }
    }
}
