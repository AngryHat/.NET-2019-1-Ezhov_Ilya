using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Rectangle : Figure
    {
        private double _width;
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new Exception("Width must be positive.");
                }
            }
        }
        private double _length;
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
                else
                {
                    throw new Exception("Length must be positive.");
                }
            }
        }
        public double Area;
        public void GetRectangleArea()
        {
            Area = Width * Length;
        }
        public double ShowRactangleArea()
        {
            GetRectangleArea();
            return Area;
        }
        public override void Draw()
        {
            Console.WriteLine($"\nRectangle has been created. Start coordinates (top, left) - {startX},{startY}; width - {Width:F3}; length - {Length:F3}; area - { ShowRactangleArea():F3}.\n");
        }

        public Rectangle(int sX, int sY, double w, double l)
        {
            startX = sX;
            startY = sY;
            Width = w;
            Length = l;
            Draw();
        }
    }

}
