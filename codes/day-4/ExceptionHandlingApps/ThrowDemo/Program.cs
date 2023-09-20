using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = null;
            try
            {
                calculation = new Calculation();
                int res = calculation.Divide(12, 0);
                Console.WriteLine(res);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
