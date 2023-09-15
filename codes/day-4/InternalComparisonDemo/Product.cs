using System;

namespace InternalComparisonDemo
{
    public class Product : IComparable<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        //internalization of comparison
        public int CompareTo(Product other)
        {
            //return this.Id.CompareTo(other.Id);    
            if (this.Id.CompareTo(other.Id) == 0)
                if (this.Price.CompareTo(other.Price) == 0)
                    return this.Name.CompareTo(other.Name);
                else
                    return this.Price.CompareTo(other.Price);
            else
                return this.Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return $"{Name}, {Id}, {Price}, {Description}";
        }
    }
}
