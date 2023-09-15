using System;
using System.Collections.Generic;

namespace InternalComparisonDemo
{
    internal class Program
    {
        static void Main()
        {
            var products = new List<Product>
            {
                new Product { Id = 2, Name="Dell XPS", Description="New laptop from dell", Price=120000},
                new Product { Id = 1, Name="HP Envy", Description="New laptop from hp", Price=150000},
                new Product { Id = 3, Name="Mac Pro 3", Description="New laptop from apple", Price=110000},
            };

            //for (int i = 0; i < products.Count; i++)
            //{
            //    for (int j = i + 1; j < products.Count; j++)
            //    {
            //        int res = products[i].CompareTo(products[j]);
            //        if (res > 0)
            //        {
            //            Product product = products[i];
            //            products[i] = products[j];
            //            products[j] = product;
            //        }
            //    }
            //}

            //this demands that the Product class must implement IComparable<Product> interface
            //as the Sort method calls CompareTo method on one product instance and passes another product instance as argument and based on the return value, it shuffles the references of the product instances inside the collection
            //products.Sort();


            //this demands that the another class must implement IComparer<Product> interface
            //as the Sort method calls Compare method and passes two instances of product class at a time from the list as arguments and based on the return value, it shuffles the references of the product instances inside the collection
            var comp = new ProductComparison(1);
            products.Sort(comp);
            //for (int i = 0; i < products.Count; i++)
            //{
            //    for (int j = i + 1; j < products.Count; j++)
            //    {
            //        int res = comp.Compare(products[i],products[j]);
            //        if (res > 0)
            //        {
            //            Product product = products[i];
            //            products[i] = products[j];
            //            products[j] = product;
            //        }
            //    }
            //}
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
        }
    }
}
