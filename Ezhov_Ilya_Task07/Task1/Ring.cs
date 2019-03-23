using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Ring : Round
    {
        public double RingArea;
        private double innerArea;
        private double _innerRadius;
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                if (value > 0)
                {
                    _innerRadius = value;
                }
                else
                {
                    throw new Exception("Inner radius must be positive.");
                }
            }
        }
        public void GetInnerArea()
        {
            innerArea = Math.PI * InnerRadius * InnerRadius;
        }
        public double ShowRingArea()
        {
            GetInnerArea();
            GetRoundArea();
            RingArea = Area - innerArea;
            return RingArea;
        }
        public override void Draw()
        {
            Console.WriteLine($"\nRing has been created. Start coordinates - {startX},{startY}; outer radius - {Radius:F3}; inner raduis - {InnerRadius:F3}; area - {ShowRingArea():F3}.\n");
        }

        public Ring(int sX, int sY, double r, double ir)
        {
            startX = sX;
            startY = sY;
            Radius = r;
            InnerRadius = ir;
            Draw();
        }
    }
}
