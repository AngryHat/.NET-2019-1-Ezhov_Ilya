using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Line : Figure
    {
        int endX;
        int endY;
        public override void Draw()
        {
            Console.WriteLine($"\nLine has been created. Start coordinates - {startX},{startY}; end coordinates - {endX},{endY}.\n");
        }

        public Line(int sX, int sY, int eX, int eY)
        {
            startX = sX;
            startY = sY;
            endX = eX;
            endY = eY;
            Draw();
        }
    }
}
