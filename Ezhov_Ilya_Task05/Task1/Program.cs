using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class User
    {
        public string FirstName;
        public string LastName;
        public string PatronymicName;
        public DateTime BirthDate;

        public int Age {
            get
            {
                int _ageCorrection = 0;
                if (DateTime.Now.Month < BirthDate.Month || (DateTime.Now.Month == BirthDate.Month && DateTime.Now.Day < BirthDate.Day))
                {
                    _ageCorrection = 1;
                }
                return DateTime.Now.Year - BirthDate.Year - _ageCorrection;
            }
            private set {}
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

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This porgram creates new User with entered by console params.");

            Console.Write("Enter first name of new user: ");
            string fName = Console.ReadLine();
            Console.Write("Enter second name of new user: ");
            string lName = Console.ReadLine();
            Console.Write("Enter patronymic name of new user: ");
            string pName = Console.ReadLine();
            Console.Write("Enter year of birth of new user: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month of birth of new user: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter day of birth of new user:\t");
            int day = Convert.ToInt32(Console.ReadLine());
            
            User admin = new User(fName, lName, pName, year, month, day);
            admin.UserShowInfo();

            Console.WriteLine("\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }
    }
}
