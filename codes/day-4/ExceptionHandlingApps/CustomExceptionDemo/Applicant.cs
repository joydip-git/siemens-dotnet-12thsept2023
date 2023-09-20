using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionDemo
{
    class Applicant
    {
        private string name;
        private int age;

        public string Name { get { return name; } set { name = value; } }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    InvalidAgeException ex = new InvalidAgeException("Age should be more or equal to 18", DateTime.Now);
                    throw ex;
                }
                age = value;
            }
        }
    }
}
