using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethodsOfCollection
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = new List<int> { 1, 3, 4, 0, 6, 7, 2, 8, 9, 5 };
            //LINQ:

            //a. method query syntax
            //list.Where(a => a % 2 == 0)
            //     .OrderBy(a => a)
            //     .TakeWhile(a => a < 3)
            //     .ToList<int>()
            //     .ForEach(a => Console.WriteLine(a));

            //b. query operator syntax
            var query = from a in list
                        orderby a
                        where a % 2 == 0 && a < 3
                        select a;

            //select <col-name> from <table-name> where primary_key_col = value

            query.ToList<int>().ForEach(x => Console.WriteLine(x));

        }
    }
}
