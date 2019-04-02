namespace QPE.Validator
{
    public class RuleError
    {
        private RuleFor RuleFor { get; }
        public IRule Rule { get; }
        public string FieldName => RuleFor.Name;
        public string DisplayName => RuleFor.DisplayName;

        internal RuleError(Validator validator, RuleFor ruleFor, IRule rule)
        {
            RuleFor = ruleFor;
            Rule = rule;
            //validator.Config.ErrorMessages[rule.Name];
        }
    }
}