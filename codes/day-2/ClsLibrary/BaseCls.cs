using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsLibrary
{
    public class BaseCls
    {
        private string dept;
        protected int id;
        internal double salary;

        public BaseCls() { }

        public BaseCls(string dept, int id, double salary)
        {
            this.dept = dept;
            this.id = id;
            this.salary = salary;
        }

        public virtual string GetInfo()
        {
            return $"{id}, {dept}, {salary}";
        }
    }
}
