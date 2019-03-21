using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        private bool _exist;
        private double _perimeter;
        private double _area;
        private double _a;
        public double SideA
        {
            get
            {
                return _a;
            }
            set
            {
                if (value > 0)
                {
                    _a = value;
                }
                else
                {
                    Console.WriteLine("Size can't be less or equals zero.\n");
                }
            }
        }
        private double _sideB;
        public double SideB
        {
            get
            {
                return _sideB;
            }
            set
            {
                if (value > 0)
                {
                    _sideB = value;
                }
                else
                {
                    Console.WriteLine("Size can't be less or equals zero.\n");
                }
            }
        }
        private double _sideC;
        public double SideC
        {
            get
            {
                return _sideC;
            }
            set
            {
                if (value > 0)
                {
                    _sideC = value;
                }
                else
                {
                    Console.WriteLine("Size can't be less or equals zero.\n");
                }
            }
        }
        
        public Triangle(double _a, double _b, double _c)
        {
            if ((_a <= _b + _c) && (_b <= _a + _c) && (_c <= _a + _b))
            {
                _exist = true;
                SideA = _a;
                SideB = _b;
                SideC = _c;
                this.GetPerimeter();
                this.GetArea();
            }
        }

        public void GetPerimeter()
        {
            _perimeter = SideA + SideB + SideC;
        }
        public void GetArea()
        {
            double p = _perimeter / 2;
            _area = Math.Sqrt((p) * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public void ShowInfo()
        {
            if (_exist)
            {
                Console.WriteLine($"\nSides of triangle: {SideA}, {SideB} and {SideC}.");
                Console.WriteLine($"Perimeter of triangle: {_perimeter}.");
                Console.WriteLine($"Area of triangle: {_area}.");
            }
            else
            {
                Console.WriteLine("\nTriangle does not exist.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("This program reads sides of triangle from the console and outputs information about it.\n");
            Console.Write("Enter side A coordinate of the round: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side B coordinate of the round: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter side C coordinate of the round: ");
            double c = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(a,b,c);
            triangle.ShowInfo();

            Console.WriteLine("\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }
    }
}
