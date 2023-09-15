using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class Program
    {
        //T => Type Parameter (naimg convention: uppercase letter)
        //TInput => Type Parameter
        //static void Add<TInput>(TInput a, TInput b) where TInput : struct
        static void Add<TInput>(TInput a, TInput b) where TInput : struct
        {
            //Console.WriteLine(a + b);
        }
        static void Add<T1, T2>(T1 a, T2 b)
        {

        }
        static void Main()
        {
            Add<int>(12, 13);
            Add<string, string>("siemens", "bangalore");
            Add<int, short>(12, 3);

            MyCollection<int> myCollection = new MyCollection<int>();
            myCollection.Add(12);
        }
    }
}
