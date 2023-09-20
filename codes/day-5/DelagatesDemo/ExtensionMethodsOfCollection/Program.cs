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

            List<Product> products = new List<Product>
            {
                new Product { Id = 2, Name="Dell XPS", Description="New laptop from dell", Price=20000},
                new Product { Id = 1, Name="HP Probook", Description="New laptop from hp", Price=30000},
                new Product { Id = 3, Name="Asus zenbook", Description="New laptop from asus", Price=10000}
            };

            /*
            Func<Product, bool> isGreaterPrice = (Product p) => p.Price > 15000;
            Func<Product, string> nameSorting = (Product p) => p.Name;
            Action<Product> printProduct = (Product p) => Console.WriteLine(p);

            products
                .OrderBy(nameSorting)
                .Where(isGreaterPrice)
                .ToList<Product>()
                .ForEach(printProduct);
            */
            products
               .OrderBy((p) => p.Name)
               .Where((p) => p.Price > 15000)
               .ToList<Product>()
               .ForEach((p) => Console.WriteLine(p));

            var productQuery = from p in products
                               orderby p.Name
                               where p.Price > 15000
                               select p;

            foreach (var item in productQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
}
