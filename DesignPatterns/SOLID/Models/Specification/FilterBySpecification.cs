using System.Collections.Generic;
using SOLID.Models.OpenClosed;

namespace SOLID.Models.Specification
{
    public class FilterBySpecification : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> products, ISpecification<Product> spec)
        {
            foreach (var product in products)
            {
                if (spec.IsSatisfied(product))
                {
                    yield return product;
                }
            }
        }
    }
}