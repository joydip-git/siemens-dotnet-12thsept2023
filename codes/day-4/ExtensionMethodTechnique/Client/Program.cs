using CalculationLibrary;
using System.Collections.Generic;

using CalculationExtensionLibrary;
using System.Linq;

using System;



namespace Client
{
    static class ListExtension
    {
        public static List<T> Filter<T>(this List<T> list, Func<T, bool> func)
        {
            List<T> result = new List<T>();
            foreach (var item in list)
            {
                bool isTrue = func(item);
                if (isTrue)
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main()
        {
            ICalculation calculation = new Calculation();
            Console.WriteLine(calculation.Add(12, 3));
            Console.WriteLine(calculation.Subtract(12, 3));
            Console.WriteLine(calculation.Multiply(12, 3));
            Console.WriteLine(calculation.Divide(12, 3));

            List<int> ints = new List<int> { 1, 3, 4, 0, 6, 7, 2, 8, 9, 5 };

            Func<int, bool> isEven = (num) => num % 2 == 0;
            //IEnumerable<int> evenNumbers = ints.Where(isEven);
            var evenNumbers = ints.Where(isEven);

            Func<int, int> sort = a => a;
            var sortedEvenNumbers = evenNumbers.OrderBy(sort);

            Func<int, bool> isLesser = (num) => num < 3;
            var selectedSortedEvenNumbers = sortedEvenNumbers.TakeWhile(isLesser);

            List<int> finalCollection = selectedSortedEvenNumbers.ToList<int>();

            Action<int> printNum = (num) => Console.WriteLine(num);
            finalCollection.ForEach(printNum);
        }
    }
}
