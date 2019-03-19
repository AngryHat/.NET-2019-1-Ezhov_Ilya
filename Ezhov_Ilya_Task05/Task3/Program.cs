using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        public bool Exist;
        public double Perimeter;
        public double Area;
        private double _sideA;
        public double SideA
        {
            get
            {
                return _sideA;
            }
            set
            {
                if (value > 0)
                {
                    _sideA = value;
                }
                else
                {
                    Console.WriteLine("Size can't be less or equals zero.\n");
                    Exist = false;
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
                    Exist = false;
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
                    Exist = false;
                }
            }
        }
        public void TriangleEixst()
        {
            if ((_sideA <= _sideB + _sideC) && (_sideB <= _sideA + _sideC) && (_sideC <= _sideA + _sideB))
            {
                Exist = true;
            }
            else
            {
                Console.WriteLine("Size can't be less or equals zero.\n");
                Exist = false;
            }
        }
        public void GetPerimeter()
        {
            Perimeter = SideA + SideB + SideC;
        }
        public void GetArea()
        {
            double p = Perimeter / 2;
            Area = Math.Sqrt((p) * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public void ShowInfo()
        {
            if (Exist)
            {
                Console.WriteLine($"\nSides of triangle: {SideA}, {SideB} and {SideC}.");
                Console.WriteLine($"Perimeter of triangle: {Perimeter}.");
                Console.WriteLine($"Area of triangle: {Area}.");
            }
            else
            {
                Console.WriteLine("Triangle does not exist.\n");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Console.WriteLine("This program reads sides of triangle from the console and outputs information about it.\n");
            Console.Write("Enter side A coordinate of the round: ");
            triangle.SideA = double.Parse(Console.ReadLine());
            Console.Write("Enter side B coordinate of the round: ");
            triangle.SideB = double.Parse(Console.ReadLine());
            Console.Write("Enter side C coordinate of the round: ");
            triangle.SideC = double.Parse(Console.ReadLine());
            triangle.TriangleEixst();
            triangle.GetPerimeter();
            triangle.GetArea();
            triangle.ShowInfo();

            Console.WriteLine("\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }
    }
}
