using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Calculation
    {
        public void Add(int x, int y) { }
        public void Add(int x, int y, int z) { }
        public void Add(int x, int y, long z) { }
        public void Add(int x, long z, int y) { }
    }
    internal class Program
    {
        static void Main()
        {
            Calculation calculation = new Calculation();
            calculation.Add(1, 2);
        }
    }
}
