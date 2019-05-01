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
            int a = 5;
            int b = 632;
            int c = -12;
            int[] arr = new int[] { 4, 8, 15, 16, 23, 42 };
            Console.WriteLine("This program contains dynamic arrays class. Here is an examples of using this class.\n");
            DynamicArray<int> dyn1 = new DynamicArray<int>();
            Console.WriteLine($"1. Empty array of type int has been created. Capacity of array: {dyn1.Capacity}:");
            Console.WriteLine($"2. Using method .Add to add our first element: {a}:");
            dyn1.Add(a);
            dyn1.ShowArray();
            Console.WriteLine($"3. Using method .Add to add another element: {b}:");
            dyn1.Add(b);
            dyn1.ShowArray();
            Console.WriteLine("4. Using method .AddRange to add array: { 4, 8, 15, 16, 23, 42 }:");
            dyn1.AddRange(arr);
            dyn1.ShowArray();
            Console.WriteLine($"5. Using method .Remove to remove second element ({b}):");
            dyn1.Remove(1);
            dyn1.ShowArray();
            Console.WriteLine($"6. Using method .Insert to insert element {b} at index {a}:");
            dyn1.Insert(b, a);
            dyn1.ShowArray();
            Console.WriteLine($"7. Using [index] to set value {c} for the last element:");
            dyn1[7] = c;
            dyn1.ShowArray();
            Console.WriteLine($"8. Using foreach (with own Enumerator) to get all vaqlues in one line:"); //foreach added
            foreach (var e in dyn1)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine("\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }
    }
}