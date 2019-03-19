using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Empolyee : User
    {
        private int _experience;
        public int Experience
        {
            get
            {
                return _experience;
            }
            
            set
            {
                if (value >= 0)
                {
                    _experience = value;
                }
                else
                    _experience = 0;
            }
        }
        private string _position;
        public string Position
        {
            get
            {
                return _position;
            }
            set
            {
                if (value != null)
                {
                    _position = value;
                }
                else
                {
                    _position = "position unknown";
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
