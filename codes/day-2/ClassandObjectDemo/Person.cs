using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObjectDemo
{
    internal class Person
    {
        private int id;
        private string name;
        //field-initialization
        //readonly static data member
        //can be assigned through static constructor only
        private static readonly double yearlyBonus;// = 10000;

        //is used to assign values to static data members only
        //this ctor is called ony one time
        //a. creating the first object
        //b. accessing a static member for the first time
        //this can't be overloaded, since this ctor is never explicitly called by user 
        //this ctor is called implicitly
        static Person()
        {
            yearlyBonus = 10000;
            Console.WriteLine("static tor called");
        }

        //instance cnstructors
        public Person()
        {
            //yearlyBonus = 10000;
        }

        public Person(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        //public static double YearlyBonus => yearlyBonus;
        public static double YearlyBonus
        {
            //set { yearlyBonus = value; }
            get { return yearlyBonus; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
