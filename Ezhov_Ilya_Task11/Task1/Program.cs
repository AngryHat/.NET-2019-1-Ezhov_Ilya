using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mathematicqal class demonstration

            int a = 10;
            int aFactorial = Mathematical.Factorial(a);
            Console.WriteLine($"Factorial of {a} is {aFactorial}.");

            int b = 2;
            int c = 10;
            int bRaised = Mathematical.RaiseToPower(b,c);
            Console.WriteLine($"Number {b} raised to power {c} is {bRaised}.");

            Console.WriteLine("End of program. Press any key.");
            Console.ReadKey();
        }
    }
}
