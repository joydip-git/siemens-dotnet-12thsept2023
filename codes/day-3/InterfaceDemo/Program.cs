using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDataAccess dataAccess = null;
            int choice = 2;
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
                //invoking interface members implemented in the class, through interface variable: explicit invocation
                dataAccess.GetData();
                Console.WriteLine(dataAccess.Data);
            }

            FileDataAccess fileDataAccess = new FileDataAccess("");
            //invoking interface members implemented in the class, through class variable: implcit invocation
            fileDataAccess.GetData();
        }
    }
}
