using System;

namespace AbstractDemo
{
    internal class Program
    {
        static void Main()
        {
            DataAccess dataAccess = null;
            int choice = 1;
            switch (choice)
            {
                case 1:
                    dataAccess = new DbDataAccess("ssjg");
                    break;

                case 2:
                    dataAccess = new FileDataAccess("");
                    break;

                default:
                    break;
            }

            if (dataAccess != null)
            {
                dataAccess.GetData();
                Console.WriteLine(dataAccess);
            }
        }
    }
}
