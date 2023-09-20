using System;

namespace ThrowDemo
{
    internal class Calculation
    {
        public int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }
        }
    }
}
