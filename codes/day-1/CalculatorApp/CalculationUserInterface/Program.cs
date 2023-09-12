using CalculationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationUserInterface
{
    internal class Program
    {
        static void PrintMenu()
        {
            Console.WriteLine("1. Add(+)");
            Console.WriteLine("2. Subtract(-)");
            Console.WriteLine("3. Multiply(*)");
            Console.WriteLine("4. Divide(/)");
            Console.WriteLine("5. Exit(e)");
        }
        static char GetChoice()
        {
            Console.Write("\nEnter a choice[+,-,*,/,e]: ");
            return char.Parse(Console.ReadLine());
        }
        static int GetNumber()
        {
            Console.Write("\nEnter a number: ");
            return int.Parse(Console.ReadLine());
        }
        static int Calculate(char choice, int first, int second)
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
        static char DecideToContinue()
        {
            Console.Write("\nWould you like to continue?[y/Y/n/N]: ");
            char ch = char.Parse(Console.ReadLine());
            return ConvertCharacterToLowerCase(ch);
        }
        static char ConvertCharacterToLowerCase(char ch)
        {
            if (char.IsUpper(ch))
                ch = char.ToLower(ch);
            return ch;
        }
        static void Main()
        {
            char continuationDecision = 'n';
            do
            {
                //1. print the menu
                PrintMenu();
                //2. ask user to make a choice
                char choice = GetChoice();
                if (choice == 'e')
                    break;

                //3. ask user to enter two values
                int firstNumber = GetNumber();
                int secondNumber = GetNumber();
                //4. perform the operation
                int result = Calculate(choice, firstNumber, secondNumber);
                //5. display the result
                Console.WriteLine(result);
                //6. ask for continutaion
                continuationDecision = DecideToContinue();
                //7. continue or exit
            } while (continuationDecision != 'n');
        }
    }
}
