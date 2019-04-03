using System;
using System.Linq.Expressions;

namespace QPE.Validator
{
    internal sealed class RequiredIf : IRule
    {
        private Expression<Func<bool>> expression;

        public string Name => "RequiredIf";


        public RequiredIf(Expression<Func<bool>> expression)
        {
            this.expression = expression;
        }

        public bool IsValid(object value)
        {
            if (expression.TailCall)
                return new Required().IsValid(value);
            return true;
        }
    }
}