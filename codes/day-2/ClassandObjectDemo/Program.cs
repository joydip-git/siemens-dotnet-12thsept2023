using System;


namespace ClassandObjectDemo
{
    internal class Program
    {
        static void Main()
        {
            Product dellXps = new Product("Dell XPS", "new laptop from dell", 1, 100000.56);
            dellXps.Price = 1200000;
            Console.WriteLine(dellXps.Price);
            Console.WriteLine(dellXps.GetInformation());

            Console.WriteLine(Person.YearlyBonus);
            Console.WriteLine(Person.YearlyBonus);
            Person person = new Person();

            const int x = 100;
        }
    }
}
