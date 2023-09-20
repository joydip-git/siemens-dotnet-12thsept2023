using System;
using System.Collections.Generic;

namespace DelegatesIntro
{
    internal class Program
    {
        //static int Main_Logic(int a,  int b)
        //{
        //    return a * b;
        //}
        static void Main()
        {
            /*
            Calculation calculation = new Calculation();
            int addRes = calculation.Add(12, 13);
            Console.WriteLine(addRes);

            int subRes = Calculation.Subtract(12, 3);
            Console.WriteLine(subRes);
            */

            //2. storing the reference to the method
            //Calculation calculation = new Calculation();
            //CalculationInvoker addDel = new CalculationInvoker(calculation.Add);
            //Console.WriteLine(addDel.Target);
            //Console.WriteLine(addDel.Method.Name);

            CalculationInvoker addDel = (x, y) => x + y;

            //CalculationInvoker subDel = new CalculationInvoker(Calculation.Subtract);
            CalculationInvoker subDel = (x, y) => x - y;

            //3. invoking the delegate in order to invoke the method
            //single-cast delegate
            //int addRes = addDel.Invoke(12, 13);
            //Console.WriteLine(addRes);

            //int subRes = subDel(12, 3);
            //Console.WriteLine(subRes);
            InvokeMethods(addDel);
            InvokeMethods(subDel);

            //multi-cast delegate
            //CalculationInvoker calcDel = new CalculationInvoker(calculation.Add);
            CalculationInvoker calcDel = (x, y) => x + y;
            //calcDel += Calculation.Subtract;
            calcDel += (x, y) => x - y;
            int calcRes = calcDel(12, 3);
            Console.WriteLine(calcRes);

            int res = 0;
            //anonymous method and anonymous delegate (2.0)
            CalculationInvoker multiDel = delegate (int a, int b)
            {
                res = a * b;
                return res;
            };
            //new style of writing anonymous method (3.0 - lambda exoression)
            //CalculationInvoker divDel = (int a, int b) =>
            //{
            //    return a / b;
            //};
            //CalculationInvoker divDel = (a, b) =>
            //{
            //    return a / b;
            //};
            //CalculationInvoker divDel = (a, b) => a / b;
            //InvokeMethods(divDel);
            InvokeMethods((a, b) => a / b);
        }
        static void InvokeMethods(CalculationInvoker del)
        {
            Console.WriteLine(del.Invoke(12, 3));
        }
    }
}
