using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Empolyee : User, IEquatable<object>
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

        public override bool Equals(object comparissonObj)
        {
            if (comparissonObj == null)
            {
                return false;
            }
            if (comparissonObj.GetType() != this.GetType())
            {
                return false;
            }
            Empolyee otherEmployee = comparissonObj as Empolyee;

            if (this.LastName == otherEmployee.LastName
                && this.FirstName == otherEmployee.FirstName
                && this.PatronymicName == otherEmployee.PatronymicName
                && this.BirthDate == otherEmployee.BirthDate)
            {
                return true;
            }
            else
            {
                return false;
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
