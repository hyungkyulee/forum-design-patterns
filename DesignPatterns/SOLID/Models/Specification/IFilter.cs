using System.Collections.Generic;

namespace SOLID.Models.Specification
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}