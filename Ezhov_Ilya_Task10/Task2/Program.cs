using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //  2 dels for person
    public delegate void PersonCome(Person p, int time);
    public delegate void personLeave(Person p);
    public delegate void Greetings(Person anotherPerson, int time);
    public delegate void Goodbyes(Person anotherPerson);


    public class Person
    {
        public event PersonCome OnCome;
        public event personLeave OnLeave;


        public string Name { get; set; }
        public static int TimeOfday
        {
            get
            {
                return DateTime.Now.Hour;
            }
        }

        public void SayHi(Person anotherPerson, int time)
        {
            if (time < 12)
            { Console.WriteLine($"{Name} sayd good morning to {anotherPerson.Name}."); }
            if (time < 17)
            { Console.WriteLine($"{Name} sayd good аfternoon to {anotherPerson.Name}."); }
            else
            { Console.WriteLine($"{Name} sayd good evening to {anotherPerson.Name}."); }

        }
        public void SayBye(Person anotherPerson)
        {
            Console.WriteLine($"{Name} sayd bye to {anotherPerson.Name}.");
        }
        public void ComeToOffice()
        {
            OnCome?.Invoke(this, TimeOfday);
        }
        public void LeaveOffice()
        {
            OnLeave?.Invoke(this);
        }

        public Person(string inputName)
        {
            Name = inputName;
        }
    }

    class Office
    {
        public Greetings EveryoneSayHi;
        public Goodbyes EveryoneSayBye;

        public Office(List<Person> persons)
        {
            foreach (var p in persons)
            {
                p.OnCome += OnCameHandler;
                p.OnLeave += OnLeaveHandler;
            }
        }

        private void OnCameHandler(Person p, int time)
        {
 
            Console.WriteLine($"{p.Name} came to office.");
            EveryoneSayHi?.Invoke(p, Person.TimeOfday);

            EveryoneSayHi += p.SayHi;
            EveryoneSayBye += p.SayBye;
            Console.WriteLine();
        }

        private void OnLeaveHandler(Person p)
        {

            Console.WriteLine($"{p.Name} left the office.");
            EveryoneSayHi -= p.SayHi;
            EveryoneSayBye -= p.SayBye;

            EveryoneSayBye?.Invoke(p);
            Console.WriteLine();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program uses delegates and simulates persons behavior, when every single person come and leave office." +
                "\nHere is an axample:\n\n");

            List<Person> employees = new List<Person>();
            
            Person Alex = new Person("Alex");
            Person Dave = new Person("Dave");
            Person George = new Person("George");
            Person Jane = new Person("Jane");

            employees.Add(Alex);
            employees.Add(Dave);
            employees.Add(George);
            employees.Add(Jane);

            Office office = new Office(employees);

            Alex.ComeToOffice();
            Dave.ComeToOffice();
            George.ComeToOffice();
            Jane.ComeToOffice();

            Jane.LeaveOffice();
            Alex.LeaveOffice();
            George.LeaveOffice();
            Console.WriteLine("Dave died.");


            Console.ReadKey();
        }
    }
}

