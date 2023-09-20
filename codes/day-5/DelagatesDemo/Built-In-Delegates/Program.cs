using System;
using System.Collections.Generic;
using System.Linq;

namespace Built_In_Delegates
{
    internal class Program
    {
        static void Main()
        {
            //Func<>, Predicate<>, Action<>, Comparison<>
            Action<string> printDel = (name) => Console.WriteLine(name);
            printDel("joydip");

            Predicate<int> evenDel = (num) => num % 2 == 0;
            bool isEven = evenDel(12);
            Console.WriteLine(isEven ? "even" : "Odd");

            Func<int, bool> oddDel = (num) => num % 2 != 0;
            bool isOdd = oddDel(13);
            Console.WriteLine(isOdd ? "odd" : "even");

            Comparison<int> compareDel = (a, b) => a - b;
            int compRes = compareDel(2, 3);
            Console.WriteLine(compRes > 0 ? "2 is greater than 3" : "3 is greater than 2");


            List<int> list = new List<int> { 0, 3, 1, 5, 7, 4, 8, 2, 9, 6 };

            //LINQ: Language Integrated Query
            list
                .Where((num) => num % 2 == 0)
                .OrderBy(a => a)
                .ToList<int>()
                .ForEach(a => Console.WriteLine(a));

            //List<int> evenNumbers = new List<int>();
            //foreach (var item in list)
            //{
            //    if (item % 2 == 0)
            //    {
            //        evenNumbers.Add(item);  
            //    }
            //}
            //foreach (var item in evenNumbers)
            //{
            //    Console.WriteLine(item);
            //}


            //Comparison<int> compareDel = (a, b) => a - b;
            //list.Sort(compareDel);
            //Action<int> printNumber = (num) => Console.WriteLine(num);
            //list.ForEach(printNumber);

            // list.Sort((a, b) => a - b);
            //Func<int, bool> isEvenNumber = (num) => num % 2 == 0;
            //IEnumerable<int> evenValues = list.Where(isEvenNumber);
            //evenValues.ToList<int>().ForEach(x => Console.WriteLine(x));



        }
    }
}

