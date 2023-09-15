using OutstandingPersonApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingPersonApp.UserInterface
{
    internal class Program
    {
        static int GetNumberOfRecords()
        {
            Console.Write("how many records? ");
            return int.Parse(Console.ReadLine());
        }
        static void PrintMenu()
        {
            Console.WriteLine("\n1. Create Student");
            Console.WriteLine("2. Create Professor");
        }
        static int GetChoice()
        {
            Console.Write("\nenter choice[1/2]: ");
            return int.Parse(Console.ReadLine());
        }
        static Person CreatePerson(int choice)
        {
            Console.Write("\nEnter Name: ");
            string personName = Console.ReadLine();

            Person person;
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Branch: ");
                    string studentBranch = Console.ReadLine();
                    Console.Write("Enter Marks: ");
                    double studentMarks = double.Parse(Console.ReadLine());
                    person = new Student(branch: studentBranch, name: personName, marks: studentMarks);
                    break;

                case 2:
                    Console.Write("Enter Department: ");
                    string profDepartment = Console.ReadLine();
                    Console.Write("Enter Number Of Books Published: ");
                    int numberOfbooksPublished = int.Parse(Console.ReadLine());
                    person = new Professor(booksPublished: numberOfbooksPublished, name: personName, department: profDepartment);
                    break;

                default:
                    person = null;
                    break;
            }
            return person;
        }
        static void StorePerson(Person[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                //1. print menu to the user about which object to create
                PrintMenu();
                //2. ask for the choice
                int choice = GetChoice();
                //3. take all the inputs and create object
                Person person = CreatePerson(choice);
                //5. store on the array at a index position
                people[i] = person;
            }
        }
        static void PrintOutstandingPeople(Person[] people)
        {
            Console.WriteLine("\n Outstanding People \n");
            foreach (Person person in people)
            {
                if (person.IsOutstanding())
                {
                    Console.WriteLine(person);
                }
            }
        }
        static void Main()
        {
            //1. ask user about the size of the array
            int records = GetNumberOfRecords();

            //2. create a storage to store any type of Person
            Person[] people = new Person[records];

            //3. create a person and store in the storage
            StorePerson(people);

            //4. iterate through the storage and render only the outstanding person details
            PrintOutstandingPeople(people);
        }
    }
}
