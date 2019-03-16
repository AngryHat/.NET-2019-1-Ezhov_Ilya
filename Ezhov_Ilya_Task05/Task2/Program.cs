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

        public void GetRoundArea()
        {
            Area = Math.PI * Radius * Radius;
        }
        public void GetCircumference()
        {
            Сircumference = 2 * Math.PI * Radius;
        }
        public void GetCircleInfo()
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
    class Program
    {
        static void Main(string[] args)
        {
            Round round = new Round();
            Console.WriteLine("This program reads coordinates and radius of round from the console and outputs information about it.\n");
            Console.Write("Enter X coordinate of the round: ");
            round.CenterX = double.Parse(Console.ReadLine());
            Console.Write("Enter Y coordinate of the round: ");
            round.CenterY = double.Parse(Console.ReadLine());
            Console.Write("Enter radius of the round: ");
            round.Radius = double.Parse(Console.ReadLine());
            round.GetCircumference();
            round.GetRoundArea();
            round.GetCircleInfo();

            Console.WriteLine("\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }
    }
}
