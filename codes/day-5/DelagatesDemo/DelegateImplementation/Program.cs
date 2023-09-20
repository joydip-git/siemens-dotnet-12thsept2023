using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateImplementation
{
    internal class Program
    {
        static List<int> Filter(List<int> input, Apply applyLogic)
        {
            List<int> result = new List<int>();
            foreach (var item in input)
            {
                //if (item % 2 == 0)
                bool isTrue = applyLogic.Invoke(item);
                if (isTrue)
                {
                    result.Add(item);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            //data source
            List<int> list = new List<int> { 1, 3, 2, 5, 0, 6, 9, 8, 7, 4 };

            //even number finding logic is stored in a delegate
            Logic logic = new Logic();
            Apply evenLogic = new Apply(logic.IsEven);
            List<int> evenNumbers = Filter(list, evenLogic);

            //even number finding logic is stored in a delegate
            //Logic logic = new Logic();
            //Apply oddLogic = new Apply(logic.IsOdd);
            //List<int> evenNumbers = Filter(list, oddLogic);

            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
