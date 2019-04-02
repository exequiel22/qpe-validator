namespace QPE.Validator
{
    internal class Numeric : IRule
    {
        public string Name => "Numeric";

        public bool IsValid(object value)
        {
            return value != null && int.TryParse(value.ToString(), out int _);
        }
    }
}