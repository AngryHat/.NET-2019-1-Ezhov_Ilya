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
            Console.Write("Enter first name of new user:\t");
            FirstName = Console.ReadLine();
            Console.Write("Enter second name of new user:\t");
            LastName = Console.ReadLine();
            Console.Write("Enter patronymic name of new user:\t");
            PatronymicName = Console.ReadLine();
            Console.Write("Enter year of birth of new user:\t");
            int birthDateYear = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month of birth of new user:\t");
            int birthDateMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter day of birth of new user:\t");
            int birthDateDay = Convert.ToInt32(Console.ReadLine());
            BirthDate = new DateTime(birthDateYear, birthDateMonth, birthDateDay);
            Age = (DateTime.Now.Year - BirthDate.Year);
            Console.WriteLine($"\nUser {FirstName} {LastName} {PatronymicName} has been created.\n" +
                $"Date of birth of the user is: {BirthDate.Year} {BirthDate.Month} {BirthDate.Day}.\n" +
                $"He or she is {Age} years old.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This porgram creates new User with entered by console params.");
            User admin = new User();
            admin.CreateUserFromConsole();

            Console.WriteLine("\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }
    }
}
