namespace ExampleDDD.Domain.Interfaces.Validators
{
    public interface IRule<TEntity>
    {
        string ErrorMessage { get; }
        bool IsSatisfy(TEntity T);
    }
}
