using CalculationLibrary;

namespace CalculationExtensionLibrary
{
    public static class CalculationExtension
    {
        //public static int Multiply(this Calculation calc, int a, int b)
        public static int Multiply(this ICalculation calc, int a, int b)
        {
            return a * b;
        }
        //public static int Divide(this Calculation calc, int a, int b)
        public static int Divide(this ICalculation calc, int a, int b)
        {
            return a / b;
        }
    }
}
