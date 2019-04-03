using System.Text.RegularExpressions;

namespace QPE.Validator
{
    internal class Numeric : IRule
    {
        public string Name => "Numeric";

        public bool IsValid(object value)
        {
            return value != null && Regex.IsMatch(value.ToString(), @"^\d+$");
        }
    }
}