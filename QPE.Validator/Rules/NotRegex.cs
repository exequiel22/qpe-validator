using System.Text.RegularExpressions;

namespace QPE.Validator
{
    internal class NotRegex : IRule
    {
        private Regex regex;

        public NotRegex(Regex regex)
        {
            this.regex = regex;
        }

        public string Name => "NotRegex";

        public bool IsValid(object value)
        {
            return !regex.IsMatch(value.ToString());
        }
    }
}