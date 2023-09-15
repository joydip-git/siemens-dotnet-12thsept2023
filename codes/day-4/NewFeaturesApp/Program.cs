using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewFeaturesApp
{
    internal class Program
    {
        //do not use var keyword as data type (return type or argument type in a method or in class
        //var value;
        //static var Foo(var x, var y)
        //{ }

        //optional argument with default value
        static void PassValue(int first, int second = 0)
        {
            Console.WriteLine(first + ", " + second);
        }

        static void Main()
        {
            //PassValue(10, 20);
            //named argument
            PassValue(second: 20, first: 10);

            //implcitly typed variable
            //type inference: interpreting the data type of a variable from the assigned value
            //implicitly typed variable must be assigned a value
            var x = 100;
            Console.WriteLine(x.GetType().Name);

            //strongly typed array
            //int[] arr = new int[] { 1, 2, 3, 4 };

            //implciitly typed array            
            //var arr = new[] { 1, 2, 3, 4 };
            var arr = new int[4];

            //Person person = new Person();
            //person.Name = "anil";
            //person.Id = 1;

            //object initializer
            Person person = new Person { Name = "anil", Id = 1 };
            //collection initializer
            HashSet<Person> set = new HashSet<Person>
            {
                new Person { Name = "anil", Id = 1 },
                new Person { Name = "anil", Id = 1 }
            };

            void Foo1()
            {
                Console.WriteLine("Foo1");
            }
            Foo1();
        }
    }
}
