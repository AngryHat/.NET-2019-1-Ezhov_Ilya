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
        public int Age;

        public void CreateUserFromConsole()
        {
            Console.Write("Enter first name of new user: ");
            FirstName = Console.ReadLine();
            Console.Write("Enter second name of new user: ");
            LastName = Console.ReadLine();
            Console.Write("Enter patronymic name of new user: ");
            PatronymicName = Console.ReadLine();
            Console.Write("Enter year of birth of new user: ");
            int birthDateYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month of birth of new user: ");
            int birthDateMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter day of birth of new user:\t");
            int birthDateDay = Convert.ToInt32(Console.ReadLine());
            BirthDate = new DateTime(birthDateYear, birthDateMonth, birthDateDay);
            Age = (DateTime.Now.Year - BirthDate.Year);
        }
        public void UserShowInfo()
        {
            Console.WriteLine($"\nUser: {FirstName} {LastName} {PatronymicName}\n" +
                $"Date of birth: {BirthDate.Day}/{BirthDate.Month}/{BirthDate.Year}\n" +
                $"Age: {Age}");
        }
    }
}
