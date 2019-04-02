using System;

namespace QPE.Validator
{
    internal sealed class RequiredIf : IRule
    {
        public string Name => "RequiredIf";

        private Func<bool> expression;

        public string ErrorMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public RequiredIf(Func<bool> conditionalFunc)
        {
            this.expression = conditionalFunc;
        }

        public bool IsValid(object value)
        {
            if (expression.Invoke())
            {
                return new Required().IsValid(value);
            }
            return true;
        }
    }
}