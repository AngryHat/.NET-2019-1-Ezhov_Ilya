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
            Console.WriteLine("This program creates figures with input parameters. Follow the instructions.");

            int select;
            bool inputContinues = true;
            while (inputContinues)
            {
                Console.WriteLine("Please choose one of the options:" +
                    "\n1 - create line" +
                    "\n2 - create circle" +
                    "\n3 - create rectangle" +
                    "\n4 - create round" +
                    "\n5 - create ring" +
                    "\n6 - show all created items" +
                    "\n7 - leave cicle and end program\n");
                select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Console.WriteLine();
                        Figure.LineCreate();
                        break;
                    case 2:
                        Console.WriteLine();
                        Figure.CircleCreate();
                        break;
                    case 3:
                        Console.WriteLine();
                        Figure.RectangleCreate();
                        break;
                    case 4:
                        Console.WriteLine();
                        Figure.RoundCreate();
                        break;
                    case 5:
                        Console.WriteLine();
                        Figure.RingCreate();
                        break;
                    case 6:
                        Console.WriteLine();
                        Figure.ShowAllItems();
                        break;
                    case 7:
                        Console.WriteLine();
                        inputContinues = false;
                        break;
                    default:
                        Console.WriteLine("\nWrong input.");
                        break;
                }

            }

            Console.WriteLine("End of program. Press any key.");
            Console.ReadKey();
        }
    }
}
