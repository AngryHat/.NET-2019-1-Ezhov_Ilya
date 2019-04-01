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
            int numberOfPeople = 158;
            Console.WriteLine($"This program removes every second element from list and linked list. Number of elements in collections is {numberOfPeople}.");

            List<Person> peopleList = new List<Person>();
            for (int i = 0; i < numberOfPeople; i++)
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
            for (int i = 0; i < numberOfPeople; i++)
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

        // new collection
        public static void RemoveEveryRemoveEachSecondItem(IEnumerable<Person> list)
        {
            while (list.Count != 1)
            {
                bool isEven = false;
                for (int i = 0; i < list.Count; i++)
                {
                    isEven = !isEven;
                    if (i % 2 == 0)
                    {
                        list.RemoveAt(i);
                    }
                }
            }
        }
        public static void RemoveEveryRemoveEachSecondItem(LinkedList<Person> list)
        {
            var current = list.First;
            var next = current.Next;

            while (list.Count != 1)
            {
                for (int i = 0; i < list.Count; i++)
                {

                    if (i % 2 == 0 && current != null)
                    {
                        list.Remove(current);
                    }
                    current = next;
                    if (next == null)
                    {
                        next = list.First;
                    }
                    else {
                        next = next.Next;
                    }
                }
            }
        }
    }
}

