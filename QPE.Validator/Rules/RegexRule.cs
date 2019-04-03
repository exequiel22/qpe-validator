using System;
using System.Text.RegularExpressions;

namespace QPE.Validator
{
    internal class RegexRule : IRule
    {
        private Regex regex;

        public RegexRule(Regex regex)
        {
            this.regex = regex;
        }

        public string Name => "Regex";

        public bool IsValid(object value)
        {
            return regex.IsMatch(value.ToString());
        }
    }
}