using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    internal abstract class DataAccess
    {
        protected string data;
        //public string Data { protected set; }
        private string path;
        public string Path { get => path; set => path = value; }

        //public abstract string Path { get; set; }

        public DataAccess() { }

        public DataAccess(string path)
        {
            Path = path;
        }
        //abstract methods are by default virtual
        public abstract void GetData();
        public abstract bool WriteData(string data);

        public override string ToString()
        {
            return data;
        }
    }
}
