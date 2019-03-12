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

        public string Name => throw new System.NotImplementedException();

        public string ErrorMessage => throw new System.NotImplementedException();

        public string SuccessMessage => throw new System.NotImplementedException();

        public bool IsValid(object value)
        {
            throw new System.NotImplementedException();
        }
    }
}