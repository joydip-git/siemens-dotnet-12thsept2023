using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    interface IMyCollection<T>
    {
        void Add(T item);
    }
    internal class MyCollection<T> : IMyCollection<T> //where T : new()
    {
        T[] values;
        static int index = 0;
        public MyCollection()
        {
            values = new T[4];
        }
        public void Add(T item)
        {
            values[index] = item;
            index++;
        }
    }
}
