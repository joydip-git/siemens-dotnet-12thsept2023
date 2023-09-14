using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    internal class FileDataAccess : DataAccess
    {
        public FileDataAccess() { }
        public FileDataAccess(string path) : base(path) { }

        public override void GetData()
        {
            data = "data from file";
        }

        public override bool WriteData(string data)
        {
            return true;
        }
    }
}
