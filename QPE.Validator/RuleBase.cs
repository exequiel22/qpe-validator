namespace QPE.Validator
{
    public abstract class RuleBase : IRule
    {
        public abstract string Name { get; }

        public abstract bool IsValid(object value);


    }
}
