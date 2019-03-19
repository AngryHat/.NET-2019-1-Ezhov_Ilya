using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Ring : Round
    {
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
                    Console.WriteLine("Radius can't be less or equals zero.\n");
                }
            }
        }
        private double _innerArea;
        public double InnerСircumference;
        public double FullCircumference;
        public double RingArea;

        public void GetInnerArea()
        {
            _innerArea = Math.PI * InnerRadius * InnerRadius;
        }
        public void GetRingArea()
        {
            RingArea = Area - _innerArea;
        }
        public void GetInnerCircumference()
        {
            InnerСircumference = 2 * Math.PI * InnerRadius;
        }
        public void GetFullCircumference()
        {
            FullCircumference = InnerСircumference + Сircumference;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
