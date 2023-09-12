using static System.Console;
//static import feature
using static CalculationUserInterface.Utilities.UiUtility;

namespace CalculationUserInterface
{
    internal class Program
    {
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
                WriteLine(result);
                //6. ask for continutaion
                continuationDecision = DecideToContinue();
                //7. continue or exit
            } while (continuationDecision != 'n');
        }
    }
}
