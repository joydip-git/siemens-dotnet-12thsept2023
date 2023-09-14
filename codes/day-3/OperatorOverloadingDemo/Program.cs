using System;
using System.Collections.Generic;

namespace OperatorOverloadingDemo
{
    internal class Program
    {
        static void Main()
        {
            string first = "Siemens";
            string second = "Bangalore";
            string location = first + ", " + second;
            Console.WriteLine(location);

            Person anilPerson = new Person(1, "anil");
            Person sunilPerson = new Person(1, "anil");
            //if(anilPerson.Equals(sunilPerson){}

            //first-operand operator second-operand
            //if (anilPerson == sunilPerson)
            //{
            //    Console.WriteLine("same");
            //}
            //else
            //    Console.WriteLine("different");
            int anilPersonHash = anilPerson.GetHashCode();
            int sunilPersonHash = sunilPerson.GetHashCode();
            if (anilPersonHash == sunilPersonHash)
            {
                //if (anilPerson.Equals(sunilPerson)
                if (anilPerson == sunilPerson)
                    Console.WriteLine("same");
            }
            else
                Console.WriteLine("different");

            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(1);

            foreach (int item in set)
            {
                Console.WriteLine(item);
            }

            HashSet<Person> people = new HashSet<Person>();
            people.Add(anilPerson);
            people.Add(sunilPerson);
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
