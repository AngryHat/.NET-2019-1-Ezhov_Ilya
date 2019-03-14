using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Stopwatch stopWatchString = new Stopwatch();
            Stopwatch stopWatchSB = new Stopwatch();
            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 200000;
            Console.WriteLine($"This program shows how much time needs to create long string ({N:000 000} chars) by concatenation strings and by string builder class.\n");

            stopWatchString.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            stopWatchString.Stop();
            TimeSpan tsString = stopWatchString.Elapsed;
            string elapsedTimeString = String.Format("{0}.{1:000} seconds.",
            tsString.Seconds, tsString.Milliseconds);
            Console.WriteLine($"Concatenation created long string for: {elapsedTimeString} \n");

            stopWatchSB.Start();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            stopWatchSB.Stop();
            TimeSpan tsSB = stopWatchSB.Elapsed;
            string elapsedTimeSB = String.Format("{0}.{1:000}  seconds.",
            tsSB.Seconds, tsSB.Milliseconds);
            Console.WriteLine($"String builder class did the same for: {elapsedTimeSB} \n");


            Console.WriteLine("\n\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }
    }
}
