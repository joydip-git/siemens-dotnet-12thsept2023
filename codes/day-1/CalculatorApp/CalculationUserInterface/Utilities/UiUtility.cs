using CalculationLibrary;
//using static System.Console;
using System;

namespace CalculationUserInterface.Utilities
{
    internal static class UiUtility
    {
        public static void PrintMenu()
        {
            Console.WriteLine("1. Add(+)");
            Console.WriteLine("2. Subtract(-)");
            Console.WriteLine("3. Multiply(*)");
            Console.WriteLine("4. Divide(/)");
            Console.WriteLine("5. Exit(e)");
        }
        public static char GetChoice()
        {
            Console.Write("\nEnter a choice[+,-,*,/,e]: ");
            return char.Parse(Console.ReadLine());
        }
        public static int GetNumber()
        {
            Console.Write("\nEnter a number: ");
            return int.Parse(Console.ReadLine());
        }
        public static int Calculate(char choice, int first, int second)
        {
            int result = 0;
            Calculation calculation = new Calculation();

            switch (choice)
            {
                case '+':
                    result = calculation.Add(first, second);
                    break;
                case '-':
                    result = calculation.Subtract(first, second);
                    break;
                case '*':
                    result = calculation.Multiply(first, second);
                    break;
                case '/':
                    result = calculation.Divide(first, second);
                    break;
                default:
                    break;
            }
            return result;
        }
        public static char DecideToContinue()
        {
            Console.Write("\nWould you like to continue?[y/Y/n/N]: ");
            char ch = char.Parse(Console.ReadLine());
            return ConvertCharacterToLowerCase(ch);
        }
        private static char ConvertCharacterToLowerCase(char ch)
        {
            if (char.IsUpper(ch))
                ch = char.ToLower(ch);
            return ch;
        }
    }
}
