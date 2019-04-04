using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class User
    {
        public string FirstName;
        public string LastName;
        public string PatronymicName;
        public DateTime BirthDate;

        public int Age
        {
            get
            {
                int _ageCorrection = 0;
                if (DateTime.Now.Month < BirthDate.Month || (DateTime.Now.Month == BirthDate.Month && DateTime.Now.Day < BirthDate.Day))
                {
                    _ageCorrection = 1;
                }
                return DateTime.Now.Year - BirthDate.Year - _ageCorrection;
            }
            private set { }
        }

        public User()
        {
        }
        public User(string _fName, string _lName, string _pName, int _year, int _month, int _day)
        {
            FirstName = _fName;
            LastName = _lName;
            PatronymicName = _pName;
            this.GetBirthDate(_year, _month, _day);
        }

        public void UserShowInfo()
        {
            Console.WriteLine($"\nUser: {FirstName} {LastName} {PatronymicName}\n" +
                $"Date of birth: {BirthDate.Day}/{BirthDate.Month}/{BirthDate.Year}\n" +
                $"Age: {Age}");
        }
        public void GetBirthDate(int year, int month, int day)
        {
            BirthDate = new DateTime(year, month, day);
        }
    }
}
