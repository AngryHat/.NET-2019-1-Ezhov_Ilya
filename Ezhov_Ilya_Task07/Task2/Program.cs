using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class GeometricProgression : Interfaces, ISeries
    {
        double start, step;
        int currentIndex;

        public GeometricProgression(double start, double step)
        {
            this.start = start;
            this.step = step;
            this.currentIndex = 1;
        }

        public double GetCurrent()
        {
            return start * Math.Pow(step,currentIndex);
        }

        public bool MoveNext()
        {
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GeometricProgression gp = new GeometricProgression(2, 2);
            Interfaces.PrintSeries(gp);

            Console.WriteLine("\nEnd of program. Press any key.");
            Console.ReadKey();
        }
    }

}
