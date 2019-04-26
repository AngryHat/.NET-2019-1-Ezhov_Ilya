using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Person
    {
        public int PersonalNumber;

        public Person(int number)
        {
            PersonalNumber = number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = 211;
            Console.WriteLine($"This program removes every second element from list and linked list. Number of elements in collections is {numberOfPeople}.");

            List<Person> peopleList = new List<Person>();
            for (int i = 1; i < numberOfPeople; i++)
            {
                peopleList.Add(new Person(i));
            }
            RemoveEveryRemoveEachSecondItem(peopleList);
            foreach (var person in peopleList)
            {
                // to be sure there is only person left
                Console.WriteLine($"\nThe lone survivor from List is person with number {person.PersonalNumber}.");
            }

            LinkedList<Person> peopleLinkedList = new LinkedList<Person>();
            for (int i = 1; i < numberOfPeople; i++)
            {
                peopleLinkedList.AddLast(new Person(i));
            }
            RemoveEveryRemoveEachSecondItem(peopleLinkedList);
            foreach (var person in peopleLinkedList)
            {
                // to be sure there is only person left
                Console.WriteLine($"\nThe lone survivor from LinkedList is person with number {person.PersonalNumber}.");
            }


            Console.WriteLine("\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }

        public static void RemoveEveryRemoveEachSecondItem(ICollection<Person> inputList)
        {
            bool isEven = false;
            while (inputList.Count > 1)
            {
                var evenPersons = new List<Person>();

                foreach (var evenPerson in inputList)
                {
                    if (isEven)
                    {
                        evenPersons.Add(evenPerson);
                    }
                    isEven = !isEven;
                }
                foreach (var evenPerson in evenPersons)
                {
                    inputList.Remove(evenPerson);
                    //  Check
                    //Console.WriteLine($"Person number {evenPerson.PersonalNumber} has been removed.");
                }
            }
        }
    }
}