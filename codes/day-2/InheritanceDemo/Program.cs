using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClsLibrary;

namespace InheritanceDemo
{

    internal class Program
    {
        static void Main()
        {
            BaseCls cls = new ChildCls(1, "anil", 1, "edu");
            Console.WriteLine(cls.GetInfo());
        }
    }
}
