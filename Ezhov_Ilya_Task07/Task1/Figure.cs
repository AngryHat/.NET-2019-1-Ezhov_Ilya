using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Figure
    {
        protected int startX;
        protected int startY;
        public virtual void Draw()
        { }

        public static List<Figure> FiguresArray = new List<Figure>();
        
        public static void LineCreate()
        {
            Console.WriteLine("Enter parameters for a new line:");
            Console.Write("Start X coordinate: ");
            int sX = int.Parse(Console.ReadLine());
            Console.Write("Start Y coordinate: ");
            int sY = int.Parse(Console.ReadLine());
            Console.Write("End X coordinate: ");
            int eX = int.Parse(Console.ReadLine());
            Console.Write("End Y coordinate: ");
            int eY = int.Parse(Console.ReadLine());

            FiguresArray.Add(new Line(sX, sY, eX, eY));
        }
        public static void CircleCreate()
        {
            Console.WriteLine("Enter parameters for a new circle:");
            Console.Write("Start X coordinate: ");
            int sX = int.Parse(Console.ReadLine());
            Console.Write("Start Y coordinate: ");
            int sY = int.Parse(Console.ReadLine());
            Console.Write("Radius length: ");
            double r = double.Parse(Console.ReadLine());

            FiguresArray.Add(new Circle(sX, sY, r));
        }
        public static void RectangleCreate()
        {
            Console.WriteLine("Enter parameters for a new rectangle:");
            Console.Write("Start X coordinate: ");
            int sX = int.Parse(Console.ReadLine());
            Console.Write("Start Y coordinate: ");
            int sY = int.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Length: ");
            double l = double.Parse(Console.ReadLine());

            FiguresArray.Add(new Rectangle(sX, sY, w, l));
        }
        public static void RoundCreate()
        {
            Console.WriteLine("Enter parameters for a new round:");
            Console.Write("Start X coordinate: ");
            int sX = int.Parse(Console.ReadLine());
            Console.Write("Start Y coordinate: ");
            int sY = int.Parse(Console.ReadLine());
            Console.Write("Radius length: ");
            double r = double.Parse(Console.ReadLine());

            FiguresArray.Add(new Round(sX, sY, r));
        }
        public static void RingCreate()
        {
            Console.WriteLine("Enter parameters for a new ring:");
            Console.Write("Start X coordinate: ");
            int sX = int.Parse(Console.ReadLine());
            Console.Write("Start Y coordinate: ");
            int sY = int.Parse(Console.ReadLine());
            Console.Write("Radius length: ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Inner radius length: ");
            double ir = double.Parse(Console.ReadLine());

            FiguresArray.Add(new Ring(sX, sY, r, ir));
        }

        public static void ShowAllItems()
        {
            Console.WriteLine("Array of figures contains:\n");
            int i = 0;
            foreach (var figure in FiguresArray)
            {
                Console.WriteLine($"[{i}] - [{figure}]");
                i++;
            }
            Console.WriteLine();
        }

    }
}

