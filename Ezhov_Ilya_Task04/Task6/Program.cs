using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string sciNotation = @"^[+\-]?(?=.)(?:0|[1-9]\d*)?(?:\.\d*)?(?:\d[eE][+\-]?\d+)?$";
            string normNotation = @"^[\-]?\d*[\.]?[\d]*$";
            Console.WriteLine("This program recognize and output notation of number entered in console.\n");
            Console.Write("Enter your number: ");
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, normNotation))
            {
                Console.WriteLine("\nThis number in normal notation.");
            }
            else if 
            (Regex.IsMatch(input, sciNotation))
            {
                Console.WriteLine("\nThis number in scientific notation.");
            }
            else
            {
                Console.WriteLine("\nThis is not a number.");
            }



            Console.WriteLine("\n\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }
    }
}
