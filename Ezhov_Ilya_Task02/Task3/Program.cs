using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program draws a tree with * symbols.");
            Console.Write("Please enter N (height of tree) for output: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("N is negative or zero, output is incorrect.");
            }
            Console.WriteLine();
            getTree(n);
        }
        public static void getTree(int height)
        {
            char space = ' ';
            char star = '*';
            for (int i = 1; i <= height; i++)
            {

                for (int j = height - 1; j >= i; j--)
                {
                    System.Console.Write(space);
                }
                for (int k = 1; k < i * 2; k++)
                {
                    System.Console.Write(star);
                }
                System.Console.WriteLine();
            }

            Console.WriteLine("\n\n\nEnd of program. Press any key.");
            System.Console.ReadKey();
        }
    }
}
