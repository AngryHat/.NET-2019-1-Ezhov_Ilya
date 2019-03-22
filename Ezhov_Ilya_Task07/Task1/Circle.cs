using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Circle : Figure, IDrawable
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
                if (Radius > 0)
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
            Console.WriteLine($"Circle created. Start coordinates {startX},{startY}; radius of circle {Radius}, length is {ShowCircleLength()}.");
        }
    }
}
