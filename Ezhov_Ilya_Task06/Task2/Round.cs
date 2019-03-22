using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Round
    {
        public double CenterX;
        public double CenterY;
        public double Сircumference;
        public double Area;
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
                    Console.WriteLine("Radius can't be less or equals zero.\n");
                }
            }
        }

        public Round()
        {
        }
        public Round(double _x, double _y, double _r)
        {
            CenterX = _x;
            CenterY = _y;
            Radius = _r;
            this.GetCircumference();
            this.GetRoundArea();
        }

        public void GetRoundArea()
        {
            Area = Math.PI * Radius * Radius;
        }
        public void GetCircumference()
        {
            Сircumference = 2 * Math.PI * Radius;
        }
        public void ShowInfo()
        {
            if (Radius > 0)
            {
                Console.WriteLine($"\nRound center position: {CenterX},{CenterY}");
                Console.WriteLine($"Round radius: {Radius}");
                Console.WriteLine($"Round circumference: {Сircumference:F3}");
                Console.WriteLine($"Round area: {Area:F3}");
            }
            else
            {
                Console.WriteLine("Incorrect input.\n");
            }

        }
    }
}
