using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Circle : Figure
    {
        private double _radius;
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value > 0)
                {
                    _radius = value;
                }
                else
                {
                    throw new Exception("Raduis must be positive.");
                }
            }
        }
        public double Length;
        public void GetCircleLength()
        {
            Length = Math.PI * (Radius + Radius);
        }
        public double ShowCircleLength()
        {
            GetCircleLength();
            return Length;
        }
        public override void Draw()
        {
            Console.WriteLine($"\nCircle has been created. Start coordinates - {startX},{startY}; radius - {Radius:F3}; length - {ShowCircleLength():F3}.\n");
        }
        public Circle()
        { }
        public Circle(int sX, int sY, double r)
        {
            startX = sX;
            startY = sY;
            Radius = r;
            Draw();
        }
    }
}
