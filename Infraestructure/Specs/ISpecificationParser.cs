namespace Store_Backend.Infraestructure.Specs
{
    public interface ISpecificationParser<T>
    {
        Specification<T> ParseSpecification(string filter);
    }
}