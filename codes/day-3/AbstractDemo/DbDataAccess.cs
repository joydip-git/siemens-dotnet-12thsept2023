using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    internal class DbDataAccess : DataAccess
    {
        public DbDataAccess() { }

        public DbDataAccess(string path) : base(path) { }

        public override void GetData()
        {
            data = "data from database";
        }

        public override bool WriteData(string data)
        {
            return true;
        }
    }
}
