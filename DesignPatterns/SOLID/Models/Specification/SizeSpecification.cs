using SOLID.Models.OpenClosed;

namespace SOLID.Models.Specification
{
    public class SizeSpecification : ISpecification<Product>
    {
        private readonly Sizes _size;

        public SizeSpecification(Sizes size)
        {
            _size = size;
        }

        public bool IsSatisfied(Product product)
        {
            return product.Size.Equals(_size);
        }
    }
}