using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Round : Circle
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
            Console.WriteLine($"\nRound has been created. Start coordinates {startX},{startY}; radius - {Radius:F3}; length - {ShowCircleLength():F3}; area - {ShowRoundArea():F3}.\n");
        }

        public Round()
        { }
        public Round(int sX, int sY, double r)
        {
            startX = sX;
            startY = sY;
            Radius = r;
            Draw();
        }
    }
}
