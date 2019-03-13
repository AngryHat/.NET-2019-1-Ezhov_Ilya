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
            Console.WriteLine("This program calculates area of rectangle by 2 sides, please enter value for A and B sides:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a <= 0f || b <= 0f)
            {
                Console.WriteLine("One or both of sides has negative value or zero. Try again.");
            }
            else
            {
                double rectangleArea = a * b;
                Console.WriteLine($"Area of rectange with sides {a} and {b} is {rectangleArea}.");
            }

            Console.WriteLine("\n\n\nEnd of program. Press any key.");
            System.Console.ReadKey();
        }
    }
}
