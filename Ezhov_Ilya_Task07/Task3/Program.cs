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
            Console.Write("Enter [index] to show element of arithmetical progression(2,2) and reapiting list(5,8,6,3,1):\t");
            int index = int.Parse(Console.ReadLine());
            ArithmeticalProgression progression = new ArithmeticalProgression(2, 2);
            List list = new List(new double[] { 5, 8, 6, 3, 1 });

            double a = progression.GetNumberByIndex(index);
            Console.WriteLine($"[{index}] element of progression - {a}");
            double b = list.GetNumberByIndex(index);
            Console.WriteLine($"[{index}] element of list - {b}");



            Console.WriteLine("\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }
    }
}
