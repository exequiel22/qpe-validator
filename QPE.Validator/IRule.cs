namespace QPE.Validator
{
    public interface IRule
    {
        string Name { get; }

        bool IsValid(object value);
    }
}