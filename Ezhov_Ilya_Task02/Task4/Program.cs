using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Program
    {
        public static int spacesCounter;
        public static void Main(string[] args)
        {
            Console.WriteLine("This program draws a tree with * symbols.");
            Console.Write("Please enter N (height of tree) for output: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("N is negative or zero, output is incorrect.");
            }
            Console.WriteLine();
            spacesCounter = n;
            for (int iterations = 1; iterations <= n; iterations++, spacesCounter--)
            {
                getTree(iterations, spacesCounter);
            }

            Console.WriteLine("\n\n\nEnd of program. Press any key.");
            System.Console.ReadKey();

        }
        public static void getTree(int counter, int spaceCounter)
        {
            char space = ' ';
            char star = '*';
            for (int mainIterator = 1; mainIterator <= counter; mainIterator++)
            {
                for (int spacesBeforeString = 0; spacesBeforeString < spacesCounter; spacesBeforeString++)
                {
                    System.Console.Write(space);
                }
                for (int spacesInString = counter - 1; spacesInString >= mainIterator; spacesInString--)
                {
                    System.Console.Write(space);
                }
                for (int starsInString = 1; starsInString < mainIterator * 2; starsInString++)
                {
                    System.Console.Write(star);
                }
                System.Console.WriteLine();
            }
        }
    }
}
