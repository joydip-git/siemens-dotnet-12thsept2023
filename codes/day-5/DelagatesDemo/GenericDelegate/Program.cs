using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    //delegate int CalculationInvoker(int a, int b);
    delegate TResult CalculationInvoker<in TInput, out TResult>(TInput a, TInput b);
    delegate TResult CalculationInvoker<in T1, in T2, out TResult>(T1 a, T2 b);

    internal class Program
    {
        static void Main(string[] args)
        {
            CalculationInvoker<int, int> addDel = (a, b) => a + b;
            CalculationInvoker<int, long> subDel = (a, b) => a - b;
            CalculationInvoker<int, int, int> multiDel = (a, b) => a * b;
        }
    }
}
