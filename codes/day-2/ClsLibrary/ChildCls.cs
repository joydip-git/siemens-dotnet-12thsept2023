using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsLibrary
{
    public class ChildCls : BaseCls
    {
        private string name;
        public ChildCls(int id, string name, double salary, string dept) : base(dept, id, salary)
        {
            this.name = name;
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()}, {name}";
        }

    }
}
