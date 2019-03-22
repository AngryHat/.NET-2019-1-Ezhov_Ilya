using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Line : Figure, IDrawable
    {
        int endX;
        int endY;
        public override void Draw()
        {
            Console.WriteLine($"Line created. Start coordinates {startX},{startY}; end coordinates {endX},{endY}.");
        }
    }
}
