using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValueAndRefAndOut
{
    internal class Program
    {
        static void Swap(int a, ref int b, out int c)
        {
            c = 31;
            Console.WriteLine($"Swap: before changes {a}, {b}, {c}");
            a = 11;
            b = 21;
            Console.WriteLine($"Swap: after changes {a}, {b}, {c}");
        }
        static void Main()
        {
            int first = 10;
            int second = 20;
            int third;
            Swap(first, ref second, out third);
            Console.WriteLine($"Main: after changes in Swap {first}, {second}, {third}");

            Console.Write("enter date of birth in DD/MM/YYYY format");
            //DateTime dob = DateTime.Parse(Console.ReadLine());
            DateTime dob;
            bool possible = DateTime.TryParse(Console.ReadLine(), out dob);
            if (possible)
            {
                Console.WriteLine(dob.ToShortDateString());
            }
            else
            {
                Console.WriteLine("not possible to convet to date time");
                Console.WriteLine(dob.ToShortDateString());
            }
        }
    }
}
