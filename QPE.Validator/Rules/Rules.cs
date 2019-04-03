using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace QPE.Validator
{
    public static class Rules
    {
        public static IRule GreaterOrEqual(double value) => new GreaterOrEqual(value);

        public static IRule GreaterThan(double value) => new GreaterThan(value);

        public static IRule LessOrEqual(double value) => new LessOrEqual(value);

        public static IRule LessThan(double value) => new LessThan(value);

        public static IRule NotRegex(Regex regex) => new NotRegex(regex);

        public static IRule Numeric() => new Numeric();

        public static IRule Regex(Regex regex) => new RegexRule(regex);

        public static IRule Required() => new Required();

        public static IRule RequiredIf(Expression<Func<bool>> conditionalFunc) => new RequiredIf(conditionalFunc);

        public static IRule Date() => new DateRule();

        internal static IRule ByExpression(string expression) => Utils.GetRuleByExpression(expression);

        //public static IRule As(Type type) => new As(type);
        //public static IRule BeforeDate(DateTime date) => new BeforeDate(date);
        //public static IRule BeforeOrEqualDate(DateTime date) => new BeforeOrEqualDate(date);
        //public static IRule EMail() => new Email();
        //public static IRule InArray(params object[] values) => new InArray(values);
        //public static IRule Different() => new Different();
    }
}