using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Ring : Round, IDrawable
    {
        public double ringArea;
        public double innerRadius;
        public void GetRingArea()
        {
            Area = Math.PI * Radius * Radius;
        }
        public double ShowRingArea()
        {
            GetRingArea();
            return Area;
        }
        public override void Draw()
        {
            Console.WriteLine($"Ring created. Start coordinates {startX},{startY}; radius of circle {Radius}, length is {ShowCircleLength()}, area is {}.");
        }
    }
}
