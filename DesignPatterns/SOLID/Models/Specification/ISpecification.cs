namespace SOLID.Models.Specification
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T type);
    }
}