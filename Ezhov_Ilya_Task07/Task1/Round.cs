using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Round : Circle, IDrawable
    {
        public double Area;
        public void GetRoundArea()
        {
            Area = Math.PI * Radius * Radius;
        }
        public double ShowRoundArea()
        {
            GetRoundArea();
            return Area;
        }
        public override void Draw()
        {
            Console.WriteLine($"Circle created. Start coordinates {startX},{startY}; radius of circle {Radius}, length is {ShowCircleLength()}, area is {ShowRoundArea()}.");
        }
    }
}
