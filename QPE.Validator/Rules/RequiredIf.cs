using System;

namespace QPE.Validator
{
    internal sealed class RequiredIf : IRule
    {
        public string Name => "RequiredIf";

        public string ErrorMessage => "";

        public string SuccessMessage => "";

        private Func<bool> expression;

        public string DisplayFieldName { get; set; }

        public RequiredIf(Func<bool> conditionalFunc)
        {
            this.expression = conditionalFunc;
        }

        public bool IsValid(object value)
        {
            if (expression.Invoke())
            {
                return new Required(DisplayFieldName).IsValid(value);
            }
            return true;
        }
    }
}