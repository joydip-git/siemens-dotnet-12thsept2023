﻿namespace CalculationLibrary
{
    public class Calculation : ICalculation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
