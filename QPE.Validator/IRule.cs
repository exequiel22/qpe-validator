namespace QPE.Validator
{
    public interface IRule
    {
        string Name { get; }
        string ErrorMessage { get; }
        string SuccessMessage { get; }
        bool IsValid(object value);
    }
}
