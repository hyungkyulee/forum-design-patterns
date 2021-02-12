using System.Collections.Generic;

namespace SOLID.Models.OpenClosed
{
    public class ProductFilter
    {
        public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products,
            Sizes size)
        {
            foreach (var product in products)
            {
                if (product.Size == size)
                {
                    yield return product;
                }
            }
        }
    }
}