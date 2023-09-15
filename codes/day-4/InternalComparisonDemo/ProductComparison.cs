using System.Collections.Generic;

namespace InternalComparisonDemo
{
    //externalization of comparison
    public class ProductComparison : IComparer<Product>
    {
        private readonly int sortChoice;

        public ProductComparison(int choice)
        {
            this.sortChoice = choice;
        }

        public int Compare(Product x, Product y)
        {
            int result = 0;
            switch (sortChoice)
            {
                case 1:
                    result = x.Id.CompareTo(y.Id);
                    break;
                case 2:
                    result = x.Price.CompareTo(y.Price);
                    break;
                case 3:
                    result = x.Name.CompareTo(y.Name);
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
