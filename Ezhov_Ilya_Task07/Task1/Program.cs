using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface IDrawable
    {
        void Draw();
    }
    class Figure : IDrawable
    {
        public List <IDrawable> FiguresArray = new List <IDrawable>();
        int startX;
        int startY;
        public void Draw()
        {
        }
        public void PutInArray()
        {
            FiguresArray.Add(this);
        }
    }
    class Line : Figure , IDrawable
    {
        int endX;
        int endY;
        public void Draw(int sX, int sY, int eX, int eY)
        {
            Console.WriteLine($"Line created. Start coordinates {sX},{sY}; end coordinates {eX},{eY}.");
        }
    }
    class Circle : Figure, IDrawable
    {
        public double radius;
        public double length;
        public void GetCircleLength()
        {
            length = Math.PI * (radius + radius);
        }
        public void Draw(int sX, int sY, double r, double l)
        {
            Console.WriteLine($"Circle created. Start coordinates {sX},{sY}; radius of circle {r}, length is {l}.");
        }
    }
    class Rectangle : Figure, IDrawable
    {
        public double width;
        public double length;
        public double area;
        public void GetRectangleArea()
        {
            area = width * length;
        }
        public void Draw(int sX, int sY, double w, double l, double a)
        {
            Console.WriteLine($"Rectangle. Start coordinates (top, left) {sX},{sY}; width is {w}, length is {l}; area is {a}.");
        }
    }
    class Round : Circle , IDrawable
    {
        public double area;
        public void GetRoundArea()
        {
            area = Math.PI * radius * radius;
        }
        public void Draw(int sX, int sY, double r, double l, double a)
        {
            Console.WriteLine($"Circle created. Start coordinates {sX},{sY}; radius of circle {r}, length is {l}, area is {a}.");
        }
    }
    class Ring : Round, IDrawable
    {
        public double ringArea;
        public double innerRadius;
        public void GetRingArea()
        {
            area = Math.PI * radius * radius;
        }
        public void Draw(int sX, int sY, double r, double l, double a)
        {
            Console.WriteLine($"Ring created. Start coordinates {sX},{sY}; radius of circle {r}, length is {l}, area is {}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
