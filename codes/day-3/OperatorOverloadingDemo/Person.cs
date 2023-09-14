using System;
using System.Text.RegularExpressions;

namespace OperatorOverloadingDemo
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Person() { }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override int GetHashCode()
        {
            const int prime = 31;
            int hash = this.Id.GetHashCode() * prime + prime;
            hash = this.Name.GetHashCode() * hash + prime;
            return hash;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (obj is Person)
            {
                Person p = (Person)obj;

                if (p.Id != this.Id)
                    return false;

                if (!p.Name.Equals(this.Name))
                    return false;

                return true;
            }
            else
                return false;
        }

        public static bool operator ==(Person first, Person second)
        {
            if (ReferenceEquals(first, second))
                return true;
            else
                return first.Equals(second);

        }
        public static bool operator !=(Person first, Person second)
        {
            if (ReferenceEquals(first, second))
                return false;
            else
                return !first.Equals(second);
        }
        public static bool operator >(Person first, Person second)
        {
            if (first.Id > second.Id)
                return true;
            else
                return false;
        }
        public static bool operator <(Person first, Person second)
        {
            if (first.Id < second.Id)
                return true;
            else
                return false;
        }
    }
}
